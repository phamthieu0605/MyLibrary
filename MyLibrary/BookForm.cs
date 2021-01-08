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
    public partial class BookForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public BookForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void GridFill()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from tblBooks", conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            mda.Fill(ds);
            dgvBooks.DataSource = ds.Tables[0];
            conn.Close();
        }

        void Clear()
        {
            txtMaSach.Text = txtTenSach.Text = txtAuthor.Text = txtNxb.Text = txtPrice.Text = txtQuantity.Text = txtSearch.Text = "";
        }

        // Thêm mới sách
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text == "" || txtTenSach.Text == "" || txtAuthor.Text == "" || txtNxb.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
            else
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT MaSach FROM tblBooks WHERE MaSach = '" + txtMaSach.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                }
                else
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into tblBooks values('" + txtMaSach.Text + "', '" + txtTenSach.Text + "', '" + txtAuthor.Text + "', '" + txtNxb.Text + "', '" + txtPrice.Text + "', '" + txtQuantity.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sách thành công");
                    GridFill();
                    Clear();
                    totalBooks();
                    addCoumn();
                }
                conn.Close();
            }
        }

        int num;
        void addCoumn()
        {
            if (dgvBooks.Columns.Count < 7)
            {
                // Add column
                DataGridViewTextBoxColumn dc = new DataGridViewTextBoxColumn();
                dc.DataPropertyName = "STT";
                dc.Name = "STT";
                dgvBooks.Columns.Insert(0, dc);
            }

            for (int i = 0; i < dgvBooks.Rows.Count; i++)
            {
                num++;
                dgvBooks.Rows[i].Cells[0].Value = num;
            }
            num = 0;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            GridFill();
            Clear();
            totalBooks();
            addCoumn();
            // set width
            DataGridViewColumn column = dgvBooks.Columns[0];
            column.Width = 35;
            // set text align
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Cập nhật sách
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Nhập mã sách cần chỉnh sửa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update tblBooks set MaSach = '" + txtMaSach.Text + "', TenSach = '" + txtTenSach.Text + "', TacGia = '" + txtAuthor.Text + "', NhaXuatBan = '" + txtNxb.Text + "', Gia = '" + txtPrice.Text + "', SoLuong = '" + txtQuantity.Text + "' where MaSach = '" + txtMaSach.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!!!");
                conn.Close();
                GridFill();
                Clear();
                totalBooks();
            }
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            txtMaSach.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtTenSach.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            txtNxb.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtQuantity.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
        }

        // Xóa sách
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Nhập mã sách cần xóa");
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from tblBooks where MaSach = '" + txtMaSach.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công!!!");
                GridFill();
                Clear();
                totalBooks();
                addCoumn();
                conn.Close();
            }
        }

        // Tìm kiếm sách
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Điền từ khóa cần tìm kiếm");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchBook", conn);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvBooks.DataSource = dtblBook;
                conn.Close();
            }
        }

        // Tính tổng số quyển sách
        int total = 0;
        private void totalBooks()
        {
            if(dgvBooks.Rows.Count == 0)
            {
                lbTotal.Text = total.ToString();
            }
            else
            {
                conn.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter("SELECT SoLuong FROM tblbooks", conn);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total = Convert.ToInt32(dt.Compute("SUM(SoLuong)", string.Empty));
                }
                lbTotal.Text = total.ToString();

                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            addCoumn();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvBooks.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Workbooks.Add(Type.Missing);
                // Xuất header
                for (int i = 0; i < dgvBooks.Columns.Count; i++)
                {
                    exApp.Cells[1, i + 1] = dgvBooks.Columns[i].HeaderText; // Xuất hàng 1, là các tên cột
                }

                // Xuất content
                for (int i = 0; i < dgvBooks.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvBooks.Columns.Count; j++)
                    {
                        exApp.Cells[i + 2, j + 1] = dgvBooks.Rows[i].Cells[j].Value.ToString(); // Xuất hàng thứ 2, cột thứ 1
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
