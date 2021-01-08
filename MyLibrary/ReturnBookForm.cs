using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyLibrary
{
    public partial class ReturnBookForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        // Xóa dữ liệu ở các trường nhập
        void Clear()
        {
            txtMaTra.Text = txttsv.Text = txtPhone.Text = txtSearch.Text = txtmsv.Text = txtTenSach.Text = txtSL.Text = txtTraCuu.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        // Hiển thị dữ liệu lên datagridview
        void GridFill()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from tblreturnbook", conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            mda.Fill(ds);
            dgvReturnBook.DataSource = ds.Tables[0];
        }

        // Thêm record trả sách
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMaTra.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
            else
            {
                string returndate = ReturnDate.Value.Year.ToString() + "/" + ReturnDate.Value.Month.ToString() + "/" + ReturnDate.Value.Day.ToString();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tblreturnbook values('"+txtMaTra.Text+"', '"+txtmsv.Text+"', '"+txttsv.Text+"', '"+txtPhone.Text+"', '"+txtTenSach.Text+"', '"+txtSL.Text+"', '"+txtNgayMuon.Text+"', '"+returndate+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công");
                GridFill();
                UpdateBook();
                Clear();
                addCoumn();
            }
            Del_IssueBook();
        }

        // Xóa ở form mượn sách khi trả sách
        void Del_IssueBook()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("delete from tblissuebook where MaMuon = '"+txtMaMuon.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            GridFill();
        }

        int num;
        void addCoumn()
        {
            if (dgvReturnBook.Columns.Count < 9)
            {
                // Add column
                DataGridViewTextBoxColumn dc = new DataGridViewTextBoxColumn();
                dc.DataPropertyName = "STT";
                dc.Name = "STT";
                dgvReturnBook.Columns.Insert(0, dc);
            }

            for (int i = 0; i < dgvReturnBook.Rows.Count; i++)
            {
                num++;
                dgvReturnBook.Rows[i].Cells[0].Value = num;
            }
            num = 0;
        }

        // Lấy ra các giá trị từ bảng mượn sách
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Nhập từ khóa để tìm kiếm");
            }
            else
            {
                MySqlCommand mc = new MySqlCommand("select * from tblissuebook where MaMuon = '" + txtSearch.Text + "'", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(mc);
                DataSet ds = new DataSet();
                mda.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMaMuon.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtmsv.Text = ds.Tables[0].Rows[0][1].ToString();
                    txttsv.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPhone.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtTenSach.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtSL.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtNgayMuon.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("Mã mượn sách chưa có trong cơ sở dữ liệu");
                }
                conn.Close();
            }
        }

        // Update lại sách trong bảng Sách khi trả sách
        private void UpdateBook()
        {
            int SoLuong, newSoLuong;
            int cbsl = int.Parse(txtSL.Text);
            MySqlCommand cmd = new MySqlCommand("select * from tblbooks where TenSach = '" + txtTenSach.Text + "'", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SoLuong = int.Parse(dr["SoLuong"].ToString());
                newSoLuong = SoLuong + cbsl;
                string qUpdateBook = "update tblbooks set SoLuong = '" + newSoLuong + "' where TenSach = '" + txtTenSach.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(qUpdateBook, conn);
                cmd1.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            GridFill();
            Clear();
            addCoumn();
            // set width
            DataGridViewColumn column = dgvReturnBook.Columns[0];
            column.Width = 35;
        }

        // Tìm kiếm theo mã trả sách
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTraCuu.Text == "")
            {
                MessageBox.Show("Bạn cần điền từ khóa để tìm kiếm");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("select * from tblreturnbook where MaTraSach like concat('%" + txtTraCuu.Text + "%') || TenSV like concat('%" + txtTraCuu.Text + "%')", conn);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvReturnBook.DataSource = dtblBook;
                conn.Close();
                Clear();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if(dgvReturnBook.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Workbooks.Add(Type.Missing);
                for(int i = 0; i < dgvReturnBook.Columns.Count; i++)
                {
                    exApp.Cells[1, i + 1] = dgvReturnBook.Columns[i].HeaderText;
                }

                for(int i = 0; i < dgvReturnBook.Rows.Count; i++)
                {
                    for(int j = 0; j < dgvReturnBook.Columns.Count; j++)
                    {
                        exApp.Cells[i + 2, j + 1] = dgvReturnBook.Rows[i].Cells[j].Value.ToString();
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            addCoumn();
        }
    }
}
