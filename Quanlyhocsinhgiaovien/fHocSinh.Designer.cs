namespace Quanlyhocsinhgiaovien
{
    partial class fHocSinh
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaHocSinh = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaHocSinh = new DevComponents.DotNetBar.ButtonX();
            this.btnThemHocSinh = new DevComponents.DotNetBar.ButtonX();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaysinhhocsinh = new System.Windows.Forms.DateTimePicker();
            this.cbMalop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTimKiemHocSinh = new System.Windows.Forms.TextBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.txbHoTenMe = new System.Windows.Forms.TextBox();
            this.txbHoTenBo = new System.Windows.Forms.TextBox();
            this.txbDiaChiHocSinh = new System.Windows.Forms.TextBox();
            this.txbHotenhocsinh = new System.Windows.Forms.TextBox();
            this.txbDantoc = new System.Windows.Forms.TextBox();
            this.txbMahocsinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSuaHocSinh);
            this.panel1.Controls.Add(this.btnXoaHocSinh);
            this.panel1.Controls.Add(this.btnThemHocSinh);
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.dtpNgaysinhhocsinh);
            this.panel1.Controls.Add(this.cbMalop);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbTimKiemHocSinh);
            this.panel1.Controls.Add(this.txbGhiChu);
            this.panel1.Controls.Add(this.txbHoTenMe);
            this.panel1.Controls.Add(this.txbHoTenBo);
            this.panel1.Controls.Add(this.txbDiaChiHocSinh);
            this.panel1.Controls.Add(this.txbHotenhocsinh);
            this.panel1.Controls.Add(this.txbDantoc);
            this.panel1.Controls.Add(this.txbMahocsinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 334);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(465, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật thông tin học sinh";
            // 
            // btnSuaHocSinh
            // 
            this.btnSuaHocSinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaHocSinh.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.edit;
            this.btnSuaHocSinh.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnSuaHocSinh.Location = new System.Drawing.Point(173, 281);
            this.btnSuaHocSinh.Name = "btnSuaHocSinh";
            this.btnSuaHocSinh.Size = new System.Drawing.Size(113, 46);
            this.btnSuaHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaHocSinh.TabIndex = 13;
            this.btnSuaHocSinh.Text = "Sửa";
            this.btnSuaHocSinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSuaHocSinh.TextColor = System.Drawing.Color.Red;
            this.btnSuaHocSinh.Click += new System.EventHandler(this.btnSuaHocSinh_Click);
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaHocSinh.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.gnome_edit_delete;
            this.btnXoaHocSinh.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnXoaHocSinh.Location = new System.Drawing.Point(305, 281);
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(113, 46);
            this.btnXoaHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaHocSinh.TabIndex = 14;
            this.btnXoaHocSinh.Text = "Xóa";
            this.btnXoaHocSinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoaHocSinh.TextColor = System.Drawing.Color.Red;
            this.btnXoaHocSinh.Click += new System.EventHandler(this.btnXoaHocSinh_Click);
            // 
            // btnThemHocSinh
            // 
            this.btnThemHocSinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemHocSinh.Image = global::Quanlyhocsinhgiaovien.Properties.Resources.plus;
            this.btnThemHocSinh.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnThemHocSinh.Location = new System.Drawing.Point(45, 281);
            this.btnThemHocSinh.Name = "btnThemHocSinh";
            this.btnThemHocSinh.Size = new System.Drawing.Size(113, 46);
            this.btnThemHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemHocSinh.TabIndex = 12;
            this.btnThemHocSinh.Text = "Thêm";
            this.btnThemHocSinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThemHocSinh.TextColor = System.Drawing.Color.Red;
            this.btnThemHocSinh.Click += new System.EventHandler(this.btnThemHocSinh_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(671, 73);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 23);
            this.rdbNu.TabIndex = 7;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(560, 73);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(54, 23);
            this.rdbNam.TabIndex = 6;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinhhocsinh
            // 
            this.dtpNgaysinhhocsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinhhocsinh.Location = new System.Drawing.Point(173, 191);
            this.dtpNgaysinhhocsinh.Name = "dtpNgaysinhhocsinh";
            this.dtpNgaysinhhocsinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaysinhhocsinh.TabIndex = 4;
            // 
            // cbMalop
            // 
            this.cbMalop.FormattingEnabled = true;
            this.cbMalop.Location = new System.Drawing.Point(173, 53);
            this.cbMalop.Name = "cbMalop";
            this.cbMalop.Size = new System.Drawing.Size(200, 27);
            this.cbMalop.TabIndex = 3;
            this.cbMalop.SelectedIndexChanged += new System.EventHandler(this.cbMalop_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dân tộc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ tên mẹ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Họ tên bố:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 113);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(437, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // txbTimKiemHocSinh
            // 
            this.txbTimKiemHocSinh.Location = new System.Drawing.Point(560, 281);
            this.txbTimKiemHocSinh.Multiline = true;
            this.txbTimKiemHocSinh.Name = "txbTimKiemHocSinh";
            this.txbTimKiemHocSinh.Size = new System.Drawing.Size(213, 46);
            this.txbTimKiemHocSinh.TabIndex = 15;
            this.txbTimKiemHocSinh.TextChanged += new System.EventHandler(this.txbTimKiemHocSinh_TextChanged);
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(560, 226);
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(200, 28);
            this.txbGhiChu.TabIndex = 11;
            // 
            // txbHoTenMe
            // 
            this.txbHoTenMe.Location = new System.Drawing.Point(560, 189);
            this.txbHoTenMe.Multiline = true;
            this.txbHoTenMe.Name = "txbHoTenMe";
            this.txbHoTenMe.Size = new System.Drawing.Size(200, 28);
            this.txbHoTenMe.TabIndex = 10;
            // 
            // txbHoTenBo
            // 
            this.txbHoTenBo.Location = new System.Drawing.Point(560, 151);
            this.txbHoTenBo.Multiline = true;
            this.txbHoTenBo.Name = "txbHoTenBo";
            this.txbHoTenBo.Size = new System.Drawing.Size(200, 28);
            this.txbHoTenBo.TabIndex = 9;
            // 
            // txbDiaChiHocSinh
            // 
            this.txbDiaChiHocSinh.Location = new System.Drawing.Point(560, 104);
            this.txbDiaChiHocSinh.Multiline = true;
            this.txbDiaChiHocSinh.Name = "txbDiaChiHocSinh";
            this.txbDiaChiHocSinh.Size = new System.Drawing.Size(200, 28);
            this.txbDiaChiHocSinh.TabIndex = 8;
            // 
            // txbHotenhocsinh
            // 
            this.txbHotenhocsinh.Location = new System.Drawing.Point(173, 139);
            this.txbHotenhocsinh.Multiline = true;
            this.txbHotenhocsinh.Name = "txbHotenhocsinh";
            this.txbHotenhocsinh.Size = new System.Drawing.Size(200, 28);
            this.txbHotenhocsinh.TabIndex = 2;
            // 
            // txbDantoc
            // 
            this.txbDantoc.Location = new System.Drawing.Point(173, 226);
            this.txbDantoc.Multiline = true;
            this.txbDantoc.Name = "txbDantoc";
            this.txbDantoc.Size = new System.Drawing.Size(200, 28);
            this.txbDantoc.TabIndex = 5;
            // 
            // txbMahocsinh
            // 
            this.txbMahocsinh.Location = new System.Drawing.Point(173, 98);
            this.txbMahocsinh.Multiline = true;
            this.txbMahocsinh.Name = "txbMahocsinh";
            this.txbMahocsinh.Size = new System.Drawing.Size(200, 28);
            this.txbMahocsinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh:";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 333);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.ReadOnly = true;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(822, 139);
            this.dgvHocSinh.TabIndex = 2;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // fHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocSinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhhocsinh;
        private System.Windows.Forms.ComboBox cbMalop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox txbHoTenMe;
        private System.Windows.Forms.TextBox txbHoTenBo;
        private System.Windows.Forms.TextBox txbDiaChiHocSinh;
        private System.Windows.Forms.TextBox txbHotenhocsinh;
        private System.Windows.Forms.TextBox txbDantoc;
        private System.Windows.Forms.TextBox txbMahocsinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnThemHocSinh;
        private DevComponents.DotNetBar.ButtonX btnXoaHocSinh;
        private DevComponents.DotNetBar.ButtonX btnSuaHocSinh;
        private System.Windows.Forms.TextBox txbTimKiemHocSinh;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label label12;
    }
}