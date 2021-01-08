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
    public partial class MainForm : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=MyLibrary;Uid=root;Pwd=12345");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("select count(*) from tblissuebook", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lbIssue.Text = dt.Rows[0][0].ToString();

            MySqlDataAdapter da1 = new MySqlDataAdapter("select count(*) from tblstudents", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            lbStudents.Text = dt1.Rows[0][0].ToString();

            MySqlDataAdapter da2 = new MySqlDataAdapter("select count(*) from tblbooks", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            lbBooks.Text = dt2.Rows[0][0].ToString();

            MySqlDataAdapter da3 = new MySqlDataAdapter("select count(*) from tbllibrarians", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            lbLibrarians.Text = dt3.Rows[0][0].ToString();
            conn.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianForm librarian = new LibrarianForm();
            librarian.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm student = new StudentForm();
            student.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm book = new BookForm();
            book.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBook = new IssueBookForm();
            issueBook.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBookForm returnBook = new ReturnBookForm();
            returnBook.Show();
        }
    }
}
