namespace MyLibrary
{
    partial class IssueBookForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvIssueBook = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txttsv = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbSL = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBook)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(304, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý mượn sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số lượng";
            // 
            // dgvIssueBook
            // 
            this.dgvIssueBook.AllowUserToAddRows = false;
            this.dgvIssueBook.AllowUserToDeleteRows = false;
            this.dgvIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueBook.Location = new System.Drawing.Point(331, 86);
            this.dgvIssueBook.Name = "dgvIssueBook";
            this.dgvIssueBook.ReadOnly = true;
            this.dgvIssueBook.Size = new System.Drawing.Size(741, 463);
            this.dgvIssueBook.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(10, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 46);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.Location = new System.Drawing.Point(122, 287);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(188, 20);
            this.txtPhone.TabIndex = 33;
            // 
            // txttsv
            // 
            this.txttsv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttsv.Location = new System.Drawing.Point(122, 241);
            this.txttsv.Name = "txttsv";
            this.txttsv.ReadOnly = true;
            this.txttsv.Size = new System.Drawing.Size(188, 20);
            this.txttsv.TabIndex = 32;
            // 
            // txtmsv
            // 
            this.txtmsv.BackColor = System.Drawing.SystemColors.Control;
            this.txtmsv.Location = new System.Drawing.Point(122, 198);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.ReadOnly = true;
            this.txtmsv.Size = new System.Drawing.Size(188, 20);
            this.txtmsv.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ngày mượn";
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(122, 425);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(188, 20);
            this.IssueDate.TabIndex = 42;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tra cứu sinh viên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(235, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 45);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbBook
            // 
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(122, 334);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(188, 21);
            this.cbBook.TabIndex = 46;
            // 
            // cbSL
            // 
            this.cbSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSL.FormattingEnabled = true;
            this.cbSL.Location = new System.Drawing.Point(122, 381);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(188, 21);
            this.cbSL.TabIndex = 47;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(122, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 46);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Hủy";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Location = new System.Drawing.Point(122, 155);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(188, 20);
            this.txtMaMuon.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã mượn sách";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraCuu.Location = new System.Drawing.Point(223, 513);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(87, 44);
            this.btnTraCuu.TabIndex = 51;
            this.btnTraCuu.Text = "Tìm kiếm";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(10, 526);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(187, 20);
            this.txtTraCuu.TabIndex = 52;
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtMaMuon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbSL);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvIssueBook);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txttsv);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvIssueBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txttsv;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbSL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}