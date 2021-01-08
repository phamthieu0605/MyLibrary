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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAcc.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
                try
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter("select count(*) from tbllibrarians where TaiKhoan = '" + txtAcc.Text + "' and MatKhau = '" + txtPass.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        MainForm main = new MainForm();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        void Clear()
        {
            txtAcc.Text = txtPass.Text = "";
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
