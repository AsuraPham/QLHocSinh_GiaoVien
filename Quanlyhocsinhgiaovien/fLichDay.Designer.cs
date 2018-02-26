namespace Quanlyhocsinhgiaovien
{
    partial class fLichDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSuaTKB = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaTKB = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTKB = new DevComponents.DotNetBar.ButtonX();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDentiet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTutiet = new System.Windows.Forms.TextBox();
            this.txbNamHoc = new System.Windows.Forms.TextBox();
            this.txbThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaTKB = new System.Windows.Forms.TextBox();
            this.cbMaHocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaGV_TKB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMalop_TKB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaMonhoc_TKB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgbThoiKhoaBieu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbThoiKhoaBieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời khóa biểu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSuaTKB);
            this.panel1.Controls.Add(this.btnXoaTKB);
            this.panel1.Controls.Add(this.btnThemTKB);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbDentiet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbTutiet);
            this.panel1.Controls.Add(this.txbNamHoc);
            this.panel1.Controls.Add(this.txbThu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbMaTKB);
            this.panel1.Controls.Add(this.cbMaHocKy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbMaGV_TKB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMalop_TKB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMaMonhoc_TKB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 323);
            this.panel1.TabIndex = 3;
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(163, 216);
            this.txbTimKiem.Multiline = true;
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(200, 28);
            this.txbTimKiem.TabIndex = 13;
            this.txbTimKiem.Tag = "13";
            this.txbTimKiem.TextChanged += new System.EventHandler(this.txbTimKiemLichDay_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tìm kiếm:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSuaTKB
            // 
            this.btnSuaTKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTKB.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.edit;
            this.btnSuaTKB.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnSuaTKB.Location = new System.Drawing.Point(340, 266);
            this.btnSuaTKB.Name = "btnSuaTKB";
            this.btnSuaTKB.Size = new System.Drawing.Size(113, 46);
            this.btnSuaTKB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTKB.TabIndex = 23;
            this.btnSuaTKB.Tag = "11";
            this.btnSuaTKB.Text = "Sửa";
            this.btnSuaTKB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSuaTKB.TextColor = System.Drawing.Color.Red;
            this.btnSuaTKB.Click += new System.EventHandler(this.btnSuaTKB_Click);
            // 
            // btnXoaTKB
            // 
            this.btnXoaTKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTKB.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.gnome_edit_delete;
            this.btnXoaTKB.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnXoaTKB.Location = new System.Drawing.Point(522, 266);
            this.btnXoaTKB.Name = "btnXoaTKB";
            this.btnXoaTKB.Size = new System.Drawing.Size(113, 46);
            this.btnXoaTKB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTKB.TabIndex = 24;
            this.btnXoaTKB.Tag = "12";
            this.btnXoaTKB.Text = "Xóa";
            this.btnXoaTKB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoaTKB.TextColor = System.Drawing.Color.Red;
            this.btnXoaTKB.Click += new System.EventHandler(this.btnXoaTKB_Click);
            // 
            // btnThemTKB
            // 
            this.btnThemTKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTKB.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.plus;
            this.btnThemTKB.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnThemTKB.Location = new System.Drawing.Point(163, 266);
            this.btnThemTKB.Name = "btnThemTKB";
            this.btnThemTKB.Size = new System.Drawing.Size(113, 46);
            this.btnThemTKB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTKB.TabIndex = 22;
            this.btnThemTKB.Tag = "10";
            this.btnThemTKB.Text = "Thêm";
            this.btnThemTKB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThemTKB.TextColor = System.Drawing.Color.Red;
            this.btnThemTKB.Click += new System.EventHandler(this.btnThemTKB_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Đến tiết:";
            // 
            // txbDentiet
            // 
            this.txbDentiet.Location = new System.Drawing.Point(597, 216);
            this.txbDentiet.Multiline = true;
            this.txbDentiet.Name = "txbDentiet";
            this.txbDentiet.Size = new System.Drawing.Size(200, 28);
            this.txbDentiet.TabIndex = 9;
            this.txbDentiet.Tag = "9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(475, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Từ tiết:";
            // 
            // txbTutiet
            // 
            this.txbTutiet.Location = new System.Drawing.Point(597, 179);
            this.txbTutiet.Multiline = true;
            this.txbTutiet.Name = "txbTutiet";
            this.txbTutiet.Size = new System.Drawing.Size(200, 28);
            this.txbTutiet.TabIndex = 8;
            this.txbTutiet.Tag = "8";
            // 
            // txbNamHoc
            // 
            this.txbNamHoc.Location = new System.Drawing.Point(597, 141);
            this.txbNamHoc.Multiline = true;
            this.txbNamHoc.Name = "txbNamHoc";
            this.txbNamHoc.Size = new System.Drawing.Size(200, 28);
            this.txbNamHoc.TabIndex = 7;
            this.txbNamHoc.Tag = "7";
            // 
            // txbThu
            // 
            this.txbThu.Location = new System.Drawing.Point(163, 179);
            this.txbThu.Multiline = true;
            this.txbThu.Name = "txbThu";
            this.txbThu.Size = new System.Drawing.Size(200, 28);
            this.txbThu.TabIndex = 4;
            this.txbThu.Tag = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Năm học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã học kỳ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thứ:";
            // 
            // txbMaTKB
            // 
            this.txbMaTKB.Location = new System.Drawing.Point(163, 53);
            this.txbMaTKB.Multiline = true;
            this.txbMaTKB.Name = "txbMaTKB";
            this.txbMaTKB.Size = new System.Drawing.Size(200, 28);
            this.txbMaTKB.TabIndex = 12;
            this.txbMaTKB.Tag = "1";
            // 
            // cbMaHocKy
            // 
            this.cbMaHocKy.FormattingEnabled = true;
            this.cbMaHocKy.Location = new System.Drawing.Point(597, 95);
            this.cbMaHocKy.Name = "cbMaHocKy";
            this.cbMaHocKy.Size = new System.Drawing.Size(200, 27);
            this.cbMaHocKy.TabIndex = 6;
            this.cbMaHocKy.Tag = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã môn học:";
            // 
            // cbMaGV_TKB
            // 
            this.cbMaGV_TKB.FormattingEnabled = true;
            this.cbMaGV_TKB.Location = new System.Drawing.Point(163, 141);
            this.cbMaGV_TKB.Name = "cbMaGV_TKB";
            this.cbMaGV_TKB.Size = new System.Drawing.Size(200, 27);
            this.cbMaGV_TKB.TabIndex = 3;
            this.cbMaGV_TKB.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã giáo viên:";
            // 
            // cbMalop_TKB
            // 
            this.cbMalop_TKB.FormattingEnabled = true;
            this.cbMalop_TKB.Location = new System.Drawing.Point(163, 96);
            this.cbMalop_TKB.Name = "cbMalop_TKB";
            this.cbMalop_TKB.Size = new System.Drawing.Size(200, 27);
            this.cbMalop_TKB.TabIndex = 2;
            this.cbMalop_TKB.Tag = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã lớp:";
            // 
            // cbMaMonhoc_TKB
            // 
            this.cbMaMonhoc_TKB.FormattingEnabled = true;
            this.cbMaMonhoc_TKB.Location = new System.Drawing.Point(597, 50);
            this.cbMaMonhoc_TKB.Name = "cbMaMonhoc_TKB";
            this.cbMaMonhoc_TKB.Size = new System.Drawing.Size(200, 27);
            this.cbMaMonhoc_TKB.TabIndex = 5;
            this.cbMaMonhoc_TKB.Tag = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã TKB:";
            // 
            // dgbThoiKhoaBieu
            // 
            this.dgbThoiKhoaBieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbThoiKhoaBieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgbThoiKhoaBieu.Location = new System.Drawing.Point(0, 329);
            this.dgbThoiKhoaBieu.Name = "dgbThoiKhoaBieu";
            this.dgbThoiKhoaBieu.Size = new System.Drawing.Size(837, 186);
            this.dgbThoiKhoaBieu.TabIndex = 4;
            // 
            // fLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 515);
            this.Controls.Add(this.dgbThoiKhoaBieu);
            this.Controls.Add(this.panel1);
            this.Name = "fLichDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLichDay";
            this.Click += new System.EventHandler(this.btnSuaTKB_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbThoiKhoaBieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaGV_TKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMalop_TKB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaMonhoc_TKB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMaTKB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTutiet;
        private System.Windows.Forms.TextBox txbNamHoc;
        private System.Windows.Forms.TextBox txbThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDentiet;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.ButtonX btnSuaTKB;
        private DevComponents.DotNetBar.ButtonX btnXoaTKB;
        private DevComponents.DotNetBar.ButtonX btnThemTKB;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.DataGridView dgbThoiKhoaBieu;
    }
}