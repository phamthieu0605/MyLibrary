namespace MyLibrary
{
    partial class LibrarianForm
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLibrarians = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMtt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarians)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(294, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thủ thư";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 266);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 20);
            this.txtPhone.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số điện thoại";
            // 
            // dgvLibrarians
            // 
            this.dgvLibrarians.AllowUserToAddRows = false;
            this.dgvLibrarians.AllowUserToDeleteRows = false;
            this.dgvLibrarians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarians.Location = new System.Drawing.Point(331, 84);
            this.dgvLibrarians.Name = "dgvLibrarians";
            this.dgvLibrarians.ReadOnly = true;
            this.dgvLibrarians.Size = new System.Drawing.Size(741, 465);
            this.dgvLibrarians.TabIndex = 38;
            this.dgvLibrarians.DoubleClick += new System.EventHandler(this.dgvLibrarians_DoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(226, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(123, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(14, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(123, 219);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 34;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(123, 173);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(178, 20);
            this.txtAcc.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 32;
            // 
            // txtMtt
            // 
            this.txtMtt.Location = new System.Drawing.Point(123, 84);
            this.txtMtt.Name = "txtMtt";
            this.txtMtt.Size = new System.Drawing.Size(178, 20);
            this.txtMtt.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã thủ thư";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(123, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 34);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Hủy";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 445);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSearch.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Location = new System.Drawing.Point(123, 486);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 36);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvLibrarians);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thủ thư";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLibrarians;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}