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
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public partial class StudentForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        public void GridFill()
        {
            string select_query = "select * from tblstudents";
            MySqlDataAdapter mda = new MySqlDataAdapter(select_query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            mda.Fill(ds);
            dgvStudents.DataSource = ds.Tables[0];
            conn.Close();
        }

        int num;
        void addCoumn()
        {
            if (dgvStudents.Columns.Count < 6)
            {
                // Add column
                DataGridViewTextBoxColumn dc = new DataGridViewTextBoxColumn();
                dc.DataPropertyName = "STT";
                dc.Name = "STT";
                dgvStudents.Columns.Insert(0, dc);
            }

            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                num++;
                dgvStudents.Rows[i].Cells[0].Value = num;
            }
            num = 0;
        }

        // Thêm mới sinh viên
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmsv.Text == "" || txttsv.Text == "" || txtlop.Text == "" || txtemail.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT MaSV FROM tblstudents WHERE MaSV = '" + txtmsv.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                }
                else
                {
                    try
                    {
                        // Kiểm tra số điện thoại có hợp lệ hay không
                        int phone = int.Parse(txtphone.Text);
                        // Kiểm tra email có hợp lệ không
                        string email = txtemail.Text;
                        Regex regex = new Regex(@"^([0-9a-zA-Z]" + @"([\+\-_\.][0-9a-zA-Z]+)*" + @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$");
                        Match match = regex.Match(email);
                        MySqlCommand cmd = new MySqlCommand("insert into tblstudents values('" + txtmsv.Text + "', '" + txttsv.Text + "', '" + txtlop.Text + "', '" + txtemail.Text + "', '" + phone + "')", conn);
                        if (match.Success)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm dữ liệu thành công!!!");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đúng địa chỉ email");
                        }
                        GridFill();
                        addCoumn();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Số điện thoại bạn điền sai");
                    }
                }
                conn.Close();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            GridFill();
            addCoumn();
            // set width
            DataGridViewColumn column = dgvStudents.Columns[0];
            column.Width = 35;
            DataGridViewColumn column1 = dgvStudents.Columns[4];
            column1.Width = 150;
        }

        // Xóa sinh viên
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtmsv.Text == "")
            {
                MessageBox.Show("Nhập mã sinh viên cần xóa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from tblstudents where MaSV = '"+txtmsv.Text+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công!!!");
                conn.Close();
                GridFill();
                Clear();
                addCoumn();
            }
        }
        // Xóa dữ liệu trên form nhập
        void Clear()
        {
            txtemail.Text = txtmsv.Text = txttsv.Text = txtlop.Text = txtphone.Text = txtSearch.Text = "";
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            addCoumn();
        }

        // Double click lấy dữ liệu ra form
        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            txtmsv.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            txttsv.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
            txtlop.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
            txtphone.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
        }

        // Cập nhật dữ liệu của sinh viên
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmsv.Text == "")
            {
                MessageBox.Show("Nhập mã sinh viên cần chỉnh sửa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update tblstudents set MaSV = '"+txtmsv.Text+ "', TenSV = '" + txttsv.Text + "', Lop = '" + txtlop.Text + "',Email = '"+txtemail.Text+"', SoDienThoai = '"+txtphone.Text+ "' where MaSV = '" + txtmsv.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!!!");
                conn.Close();
                GridFill();
                Clear();
                addCoumn();
            }
        }

        // Tìm kiếm sinh viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Điền từ khóa cần tìm kiếm");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchStudent", conn);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvStudents.DataSource = dtblBook;
                conn.Close();
                Clear();
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            // Kiểm tra email có hợp lệ hay không
            string pattern = @"^([0-9a-zA-Z]" + @"([\+\-_\.][0-9a-zA-Z]+)*" + @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";
            if (Regex.IsMatch(txtemail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtemail, "Vui lòng điền email hợp lệ");
                return;
            }
        }

        // Xuất excel
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            
            if (dgvStudents.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dgvStudents.Columns.Count; i++)
                {
                    exApp.Cells[1, i + 1] = dgvStudents.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvStudents.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvStudents.Columns.Count; j++)
                    {
                        exApp.Cells[i + 2, j + 1] = dgvStudents.Rows[i].Cells[j].Value.ToString();
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
