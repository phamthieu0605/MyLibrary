using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MyLibrary
{
    public partial class LibrarianForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
        void GridFill()
        {
            string select_query = "select * from tbllibrarians";
            MySqlDataAdapter mda = new MySqlDataAdapter(select_query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            mda.Fill(ds);
            dgvLibrarians.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            GridFill();
            addCoumn();
            // set width
            DataGridViewColumn column = dgvLibrarians.Columns[0];
            column.Width = 35;
        }

        int num;
        void addCoumn()
        {
            if (dgvLibrarians.Columns.Count < 6)
            {
                // Add column
                DataGridViewTextBoxColumn dc = new DataGridViewTextBoxColumn();
                dc.DataPropertyName = "STT";
                dc.Name = "STT";
                dgvLibrarians.Columns.Insert(0, dc);
            }

            for (int i = 0; i < dgvLibrarians.Rows.Count; i++)
            {
                num++;
                dgvLibrarians.Rows[i].Cells[0].Value = num;
            }
            num = 0;
        }

        // Thêm mới thủ thư
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMtt.Text == "" || txtName.Text == "" || txtAcc.Text == "" || txtPass.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select MaTT from tbllibrarians WHERE MaTT = '" + txtMtt.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã thủ thư đã tồn tại");
                }
                else
                {
                    // Kiểm tra số điện thoại
                    try
                    {
                        int phone = int.Parse(txtPhone.Text);
                        MySqlCommand cmd = new MySqlCommand("insert into tbllibrarians values('" + txtMtt.Text + "', '" + txtName.Text + "', '" + txtAcc.Text + "', '" + txtPass.Text + "', '" + txtPhone.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm dữ liệu thành công!!!");
                        GridFill();
                        Clear();
                        addCoumn();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Số điện thoại bạn điền chưa đúng");
                    }
                    
                }
                conn.Close();
            }
        }

        // Xóa thủ thư theo mã thủ thư
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtMtt.Text == "")
            {
                MessageBox.Show("Cần mã thủ thư để xóa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from tbllibrarians where MaTT = '" + txtMtt.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                conn.Close();
                GridFill();
                Clear();
                addCoumn();
            }
        }

        // Cập nhật dữ liệu của thủ thư
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMtt.Text == "")
            {
                MessageBox.Show("Nhập mã thủ thư cần chỉnh sửa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update tbllibrarians set MaTT = '" + txtMtt.Text + "', TenTT = '" + txtName.Text + "', TaiKhoan = '" + txtAcc.Text + "', MatKhau = '" + txtPass.Text + "', SoDienThoai = '"+txtPhone.Text+ "' WHERE MaTT = '" + txtMtt.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!!!");
                conn.Close();
                GridFill();
                Clear();
                addCoumn();
            }
        }

        void Clear()
        {
            txtMtt.Text = txtName.Text = txtAcc.Text = txtPass.Text = txtPhone.Text= txtSearch.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            addCoumn();
        }

        private void dgvLibrarians_DoubleClick(object sender, EventArgs e)
        {
            txtMtt.Text = dgvLibrarians.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvLibrarians.CurrentRow.Cells[1].Value.ToString();
            txtAcc.Text = dgvLibrarians.CurrentRow.Cells[2].Value.ToString();
            txtPass.Text = dgvLibrarians.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dgvLibrarians.CurrentRow.Cells[4].Value.ToString();
        }

        // Tìm kiếm thủ thư
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Điền từ khóa cần tìm kiếm");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchLibrarian", conn);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvLibrarians.DataSource = dtblBook;
                conn.Close();
                Clear();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvLibrarians.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dgvLibrarians.Columns.Count; i++)
                {
                    exApp.Cells[1, i + 1] = dgvLibrarians.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvLibrarians.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvLibrarians.Columns.Count; j++)
                    {
                        exApp.Cells[i + 2, j + 1] = dgvLibrarians.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exApp.Columns.AutoFit();
                exApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }
    }
}
