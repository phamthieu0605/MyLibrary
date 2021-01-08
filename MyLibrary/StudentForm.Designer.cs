namespace MyLibrary
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.txttsv = new System.Windows.Forms.TextBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.btnExportToExcel);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Blue;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportToExcel.Location = new System.Drawing.Point(967, 19);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(105, 38);
            this.btnExportToExcel.TabIndex = 13;
            this.btnExportToExcel.Text = "Xuất Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Trang chủ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(375, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(124, 87);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(178, 20);
            this.txtmsv.TabIndex = 5;
            // 
            // txttsv
            // 
            this.txttsv.Location = new System.Drawing.Point(124, 130);
            this.txttsv.Name = "txttsv";
            this.txttsv.Size = new System.Drawing.Size(178, 20);
            this.txttsv.TabIndex = 6;
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(124, 177);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(178, 20);
            this.txtlop.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(124, 268);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(178, 20);
            this.txtphone.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(124, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(227, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(331, 87);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(741, 462);
            this.dgvStudents.TabIndex = 12;
            this.dgvStudents.DoubleClick += new System.EventHandler(this.dgvStudents_DoubleClick);
            // 
            // txtClear
            // 
            this.txtClear.BackColor = System.Drawing.Color.Tan;
            this.txtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtClear.Location = new System.Drawing.Point(124, 383);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(85, 38);
            this.txtClear.TabIndex = 15;
            this.txtClear.Text = "Hủy";
            this.txtClear.UseVisualStyleBackColor = false;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(124, 491);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 40);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 453);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(124, 223);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 20);
            this.txtemail.TabIndex = 19;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.txttsv);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.TextBox txttsv;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}