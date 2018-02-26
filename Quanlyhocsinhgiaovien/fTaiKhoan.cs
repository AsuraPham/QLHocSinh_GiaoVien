using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhocsinhgiaovien
{
    public partial class fTaiKhoan : Form
    {
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        private TaiKhoan Dangnhaptaikhoan; //su dung contructor

        public TaiKhoan Dangnhaptaikhoan1
        {
            get { return Dangnhaptaikhoan; }
            set { Dangnhaptaikhoan = value; }
        }
        public fTaiKhoan(TaiKhoan tk)
        {
            InitializeComponent();
            this.Dangnhaptaikhoan1 = tk;
            DanhsachTk();
            TaiKhoanBinding();
        }
        #region //method
        void DanhsachTk()
        {
            dgvTaiKhoan.DataSource = tkbll.danhsachtaikhoan();
            dgvTaiKhoan.Columns[0].HeaderText = "Mã";
            dgvTaiKhoan.Columns[1].HeaderText = "Tên đăng nhập";
            dgvTaiKhoan.Columns[2].HeaderText = "Tên hiển thị";
            dgvTaiKhoan.Columns[3].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns[4].HeaderText = "Loại TK";
            dgvTaiKhoan.Columns[0].Width = 100;
            dgvTaiKhoan.Columns[1].Width = 150;
            dgvTaiKhoan.Columns[2].Width = 150;
            dgvTaiKhoan.Columns[3].Width = 100;
            dgvTaiKhoan.Columns[4].Width = 100;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        void TaiKhoanBinding()
        {
            txbMatk.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "matk", true, DataSourceUpdateMode.Never));
            txbTenDangNhap.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "tendn", true, DataSourceUpdateMode.Never));
            txbTenHienThi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "tenhienthi", true, DataSourceUpdateMode.Never));
            txbMatKhau.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "matkhau", true, DataSourceUpdateMode.Never));
            txbLoaiTaiKhoan.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "loaitk", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region //thao tac cac modun
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string tendn = txbTenDangNhap.Text;
            string tenhienthi = txbTenHienThi.Text;
            string matkhau = txbMatKhau.Text;
            int loaitk = int.Parse(txbLoaiTaiKhoan.Text);
            if (tkbll.ThemTaiKhoan(tendn, tenhienthi, matkhau, loaitk))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                DanhsachTk();

            }
            else
            {
                MessageBox.Show("Có lỗi thêm tài khoản");
            }
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            int matk = Convert.ToInt32(txbMatk.Text);
            string tendn = txbTenDangNhap.Text;
            string tenhienthi = txbTenHienThi.Text;
            string matkhau = txbMatKhau.Text;
            int loaitk = int.Parse(txbLoaiTaiKhoan.Text);
            if (tkbll.SuaTaiKhoan(tendn, tenhienthi, matkhau, loaitk, matk))
            {
                MessageBox.Show("Sửa thành công");
                DanhsachTk();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }
        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            int matk = Convert.ToInt32(txbMatk.Text);
            string tendn = txbTenDangNhap.Text;
            if (Dangnhaptaikhoan1.tendn.Equals(tendn))
            {
                MessageBox.Show("vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (tkbll.XoaTaiKhoan(matk))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            DanhsachTk();
        }
        #endregion
    }
}
