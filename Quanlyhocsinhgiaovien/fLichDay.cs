using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Quanlyhocsinhgiaovien
{
    public partial class fLichDay : Form
    {
        public fLichDay()
        {
            InitializeComponent();
            Load_LichDay();

        }

        LichDay_BLL ld_bll = new LichDay_BLL();
        public void Load_LichDay()
        {
            List<LichDay> ttLichDay = new List<LichDay>();
            ttLichDay = ld_bll.ThongTinLichDay();
            dgbThoiKhoaBieu.DataSource = ttLichDay;
            dgbThoiKhoaBieu.Columns[0].HeaderText = "Mã";
            dgbThoiKhoaBieu.Columns[1].HeaderText = "Mã Lớp";
            dgbThoiKhoaBieu.Columns[2].HeaderText = "Mã Giáo Viên";
            dgbThoiKhoaBieu.Columns[3].HeaderText = "Thứ";
            dgbThoiKhoaBieu.Columns[4].HeaderText = "Mã Môn Học";
            dgbThoiKhoaBieu.Columns[5].HeaderText = "Mã Học Kỳ";
            dgbThoiKhoaBieu.Columns[6].HeaderText = "Năm Học";
            dgbThoiKhoaBieu.Columns[7].HeaderText = "Tiết Bắt Đầu";
            dgbThoiKhoaBieu.Columns[8].HeaderText = "Tiết Kết Thúc";
            dgbThoiKhoaBieu.AllowUserToAddRows = false;
            dgbThoiKhoaBieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        
            Binding_LichDay();
            load_cboMaLop();
            load_cboMaGV();
            load_cboMaMH();
            load_cboMaHK();


            load_cboMaGV();
        }
        public void HienThi()
        {
            List<LichDay> ttLichDay = new List<LichDay>();
            ttLichDay = ld_bll.ThongTinLichDay();
            dgbThoiKhoaBieu.DataSource = ttLichDay;

        }
        private void Binding_LichDay()
        {
            txbMaTKB.DataBindings.Clear();
            txbMaTKB.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "maTKB");
            cbMalop_TKB.DataBindings.Clear();
            cbMalop_TKB.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "maLop");
            cbMaGV_TKB.DataBindings.Clear();
            cbMaGV_TKB.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "MaGiaoVien");
            txbThu.DataBindings.Clear();
            txbThu.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "thu");
            cbMaMonhoc_TKB.DataBindings.Clear();
            cbMaMonhoc_TKB.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "maMonHoc");
            cbMaHocKy.DataBindings.Clear();
            cbMaHocKy.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "maHocKy");
            txbNamHoc.DataBindings.Clear();
            txbNamHoc.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "namHoc");
            txbTutiet.DataBindings.Clear();
            txbTutiet.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "Tiet_bd");
            txbDentiet.DataBindings.Clear();
            txbDentiet.DataBindings.Add("Text", dgbThoiKhoaBieu.DataSource, "Tiet_kt");


        }

        public void load_cboMaLop()
        {
            LopHoc_BLL lh_bll = new LopHoc_BLL();
            List<LopHoc> dsLH = new List<LopHoc>();
            dsLH = lh_bll.LayDanhSachLopHoc();
            foreach (var item in dsLH)
            {
                string hienthi = item.MaLop + ":" + item.TenLop;
                cbMalop_TKB.Items.Add(hienthi);
            }

        }

        public void load_cboMaGV()
        {
            GiaoVien_BLL gv_bll = new GiaoVien_BLL();
            List<GiaoVien> dsGV = new List<GiaoVien>();
            dsGV = gv_bll.LayThongTinGV();
            foreach (var item in dsGV)
            {
                string hienthi = item.MaGiaoVien + ":" + item.HoTen;
                cbMaGV_TKB.Items.Add(hienthi);
            }

        }
        public void load_cboMaMH()
        {
            LichDay_BLL ld_bll = new LichDay_BLL();
            List<LichDay> dsLD = new List<LichDay>();
            dsLD = ld_bll.ThongTinLichDay();
            foreach (var item in dsLD)
            {
                string hienthi = item.MaMonHoc;
                cbMaMonhoc_TKB.Items.Add(hienthi);
            }

        }
        public void load_cboMaHK()
        {
            LichDay_BLL hk_bll = new LichDay_BLL();
            List<LichDay> dsHK = new List<LichDay>();
            dsHK = hk_bll.ThongTinLichDay();
            foreach (var item in dsHK)
            {
                string hienthi = item.MaHocKy;
                cbMalop_TKB.Items.Add(hienthi);
            }

        }

 
        private void txbTimKiemLichDay_TextChanged(object sender, EventArgs e)
        {

            try
            {
                List<LichDay> ttLichDay = new List<LichDay>();
                ttLichDay = ld_bll.TimKiemLichDay(int.Parse(txbTimKiem.Text.ToString()));
                dgbThoiKhoaBieu.DataSource = ttLichDay;
                if (int.Parse(txbTimKiem.Text.ToString()) == 0)
                {
                    Load_LichDay();
                }
            }
            catch (Exception ex)
            {
                Load_LichDay();
            }

        }



       
        private void btnSuaTKB_Click(object sender, EventArgs e)
        {
            try
            {
                LichDay ld = new LichDay();
                ld.MaTKB = int.Parse(txbMaTKB.Text.ToString());
                ld.MaLop = cbMalop_TKB.Text.Trim();
                ld.MaGiaoVien = cbMaGV_TKB.Text.Trim();
                ld.MaMonHoc = cbMaMonhoc_TKB.Text.Trim();
                ld.MaHocKy = cbMaHocKy.Text.Trim();
                ld.NamHoc = txbNamHoc.Text.Trim();
                ld.Thu = int.Parse(txbThu.Text.ToString());
                ld.Tiet_bd = int.Parse(txbTutiet.Text.ToString());
                ld.Tiet_kt = int.Parse(txbDentiet.Text.ToString());


                if (ld_bll.SuaLichDay(ld))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_LichDay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       


    private void fLichDay_Load(object sender, EventArgs e)
        {



        }


        private void btnXoaTKB_Click(object sender, EventArgs e)
        {
            int chiso = dgbThoiKhoaBieu.CurrentRow.Index;
            string matkb = txbMaTKB.Text;
            if (chiso == 0)
                MessageBox.Show("Vui lòng chọn đối tượng để xóa?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ld_bll.XoaLichDay(int.Parse(matkb)))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_LichDay();
            }
        }

        private void btnThemTKB_Click_1(object sender, EventArgs e)
        {
            try
            {
                LichDay ld = new LichDay();
                ld.MaTKB = int.Parse(txbMaTKB.Text.ToString());

                ld.MaLop = cbMalop_TKB.Text.Trim();
                ld.MaGiaoVien = cbMaGV_TKB.Text.Trim();
                ld.MaMonHoc = cbMaMonhoc_TKB.Text.Trim();
                ld.MaHocKy = cbMaHocKy.Text.Trim();

                ld.NamHoc = txbNamHoc.Text.Trim();
                ld.Thu = int.Parse(txbThu.Text.ToString());
                ld.Tiet_bd = int.Parse(txbTutiet.Text.ToString());
                ld.Tiet_kt = int.Parse(txbDentiet.Text.ToString());

                if (ld_bll.ThemLichDay(ld))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_LichDay();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
