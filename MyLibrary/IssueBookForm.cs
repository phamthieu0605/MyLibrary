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
    public partial class IssueBookForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        // Xóa dữ liệu ở các trường nhập
        void Clear()
        {
            txtmsv.Text = txttsv.Text = txtPhone.Text = txtSearch.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            addCoumn();
        }

        // Hiển thị dữ liệu lên datagridview
        void GridFill()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from tblissuebook", conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            mda.Fill(ds);
            dgvIssueBook.DataSource = ds.Tables[0];
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            GridFill();
            addCoumn();
            // set width
            DataGridViewColumn column = dgvIssueBook.Columns[0];
            column.Width = 35;

            // Load tên sách có trong bảng sách ra comboBox
            conn.Open();
            MySqlCommand mc = new MySqlCommand("select TenSach from tblBooks", conn);
            MySqlDataReader mdr = mc.ExecuteReader();
            while (mdr.Read())
            {
                for (int i = 0; i < mdr.FieldCount; i++)
                {
                    cbBook.Items.Add(mdr.GetString(i));
                }
            }

            mdr.Close();
            conn.Close();
            int[] num = { 1, 2, 3 };
            for (int j = 0; j < num.Length; j++)
            {
                cbSL.Items.Add(num[j]);
            }
        }

        // Add STT
        int num;
        void addCoumn()
        {
            if (dgvIssueBook.Columns.Count < 8)
            {
                // Add column
                DataGridViewTextBoxColumn dc = new DataGridViewTextBoxColumn();
                dc.DataPropertyName = "STT";
                dc.Name = "STT";
                dgvIssueBook.Columns.Insert(0, dc);
            }

            for (int i = 0; i < dgvIssueBook.Rows.Count; i++)
            {
                num++;
                dgvIssueBook.Rows[i].Cells[0].Value = num;
            }
            num = 0;
        }

        // Thêm mới mượn sách
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMaMuon.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
            else
            {
                int SoLuong;
                int cbsl1 = int.Parse(cbSL.SelectedItem.ToString());
                int quantity = int.Parse(cbSL.SelectedItem.ToString());
                string issuedate = IssueDate.Value.Year.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Day.ToString();
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("select SoLuong from tblbooks where TenSach = '"+cbBook.SelectedItem.ToString()+"'", conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    SoLuong = int.Parse(dr["SoLuong"].ToString());
                    if (SoLuong < cbsl1)
                    {
                        MessageBox.Show("Số lượng sách không đủ");
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into tblissuebook values('" + txtMaMuon.Text + "','" + txtmsv.Text + "', '" + txttsv.Text + "', '" + txtPhone.Text + "', '" + cbBook.SelectedItem.ToString() + "', '" + quantity + "', '" + issuedate + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm dữ liệu thành công");
                        GridFill();
                        Clear();
                    }
                }
                UpdateBook();
                addCoumn();
                conn.Close();
            }
        }

        // Update lại sách trong bảng Sách khi mượn sách
        private void UpdateBook()
        {
            int SoLuong, newSoLuong;
            int cbsl = int.Parse(cbSL.Text);
            MySqlCommand cmd = new MySqlCommand("select * from tblbooks where TenSach = '" + cbBook.Text + "'", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SoLuong = int.Parse(dr["SoLuong"].ToString());
                newSoLuong = SoLuong - cbsl;
                string qUpdateBook = "update tblbooks set SoLuong = '" + newSoLuong + "' where TenSach = '" + cbBook.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(qUpdateBook, conn);
                cmd1.ExecuteNonQuery();
            }
            conn.Close();
        }

        // Tra cứu sinh viên có trong bảng sinh viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Nhập từ khóa để tìm kiếm");
            }
            else
            {
                MySqlCommand mc = new MySqlCommand("select * from tblstudents where MaSV = '"+txtSearch.Text+"'", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(mc);
                DataSet ds = new DataSet();
                mda.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtmsv.Text = ds.Tables[0].Rows[0][0].ToString();
                    txttsv.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("Sinh viên chưa có trong cơ sở dữ liệu");
                }
                conn.Close();
            }
        }

        // Tìm kiếm mượn sách
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if(txtTraCuu.Text == "")
            {
                MessageBox.Show("Bạn cần điền từ khóa để tra cứu");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("select * from tblissuebook where MaMuon like concat('%',"+txtTraCuu.Text+ ",'%') || TenSV like concat('%'," + txtTraCuu.Text + ",'%')", conn);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvIssueBook.DataSource = dtblBook;
                conn.Close();
                Clear();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvIssueBook.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dgvIssueBook.Columns.Count; i++)
                {
                    exApp.Cells[1, i + 1] = dgvIssueBook.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvIssueBook.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvIssueBook.Columns.Count; j++)
                    {
                        exApp.Cells[i + 2, j + 1] = dgvIssueBook.Rows[i].Cells[j].Value.ToString();
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
