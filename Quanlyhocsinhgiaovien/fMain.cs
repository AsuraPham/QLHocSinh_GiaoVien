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
    public partial class fMain : Form
    {
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        private TaiKhoan Dangnhaptaikhoan; //su dung contructor

        public TaiKhoan Dangnhaptaikhoan1
        {
            get { return Dangnhaptaikhoan; }
            set { Dangnhaptaikhoan = value; Admin(Dangnhaptaikhoan.loaitk); }
        }
        public fMain(TaiKhoan tk)
        {
            InitializeComponent();
            this.Dangnhaptaikhoan1 = tk;
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            
        }
        void Admin(int type)
        {
            btnTaiKhoan.Visible = type == 1;
        }
        private void btnLich_Click(object sender, EventArgs e)
        {
            fLichDay ld =new fLichDay();
            ld.ShowDialog();
            this.Show();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            fHocSinh hs = new fHocSinh();
            hs.ShowDialog();
            this.Show();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            fGiaoVien gv = new fGiaoVien();
            gv.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            fTaiKhoan tk = new fTaiKhoan(Dangnhaptaikhoan);
            tk.ShowDialog();
            this.Show();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            
            /* System.Diagnostics.Process.Start("__Human_computer_interaction.pdf");*/
        }

        private void lb_HuongDan_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
            this.Show();
        }
    }
}
