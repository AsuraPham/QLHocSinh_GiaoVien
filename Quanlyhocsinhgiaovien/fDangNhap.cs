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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            string tentk = txbTendangnhap.Text;
            string matkhau = txbMatkhau.Text;
            if (tkbll.TaiKhoan(tentk, matkhau))
            {
                TaiKhoan Dangnhaptaikhoan = tkbll.LaytaikhautheoTendn(tentk);
                fMain fchinh = new fMain(Dangnhaptaikhoan);
                this.Hide();
                fchinh.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
