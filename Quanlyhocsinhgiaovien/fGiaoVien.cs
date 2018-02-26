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
    public partial class fGiaoVien : Form
    {
        public fGiaoVien()
        {
            InitializeComponent();
            LoadGiaoVien();
        }
        public void LoadGiaoVien()
        {
            //load du lieu
            LoaddvgGiaoVien();
        }
        GiaoVien_BLL gv_bll = new GiaoVien_BLL();
        public void LoaddvgGiaoVien()
        {
            List<GiaoVien> DsGV = new List<GiaoVien>();
            DsGV = gv_bll.LayThongTinGV();
            dgvGiaoVien.DataSource = DsGV;
            dgvGiaoVien.Columns[0].HeaderText = "Mã";
            dgvGiaoVien.Columns[1].HeaderText = "Họ Tên";
            dgvGiaoVien.Columns[2].HeaderText = "Giới Tính";
            dgvGiaoVien.Columns[3].HeaderText = "Ngày Sinh";
            dgvGiaoVien.Columns[4].HeaderText = "Chuyên Môn";
            dgvGiaoVien.Columns[5].HeaderText = "SĐT";
            dgvGiaoVien.Columns[6].HeaderText = "Dân Tộc";
            dgvGiaoVien.Columns[7].HeaderText = "Địa Chỉ";
            dgvGiaoVien.Columns[0].Width = 50;
            dgvGiaoVien.Columns[1].Width = 150;
            dgvGiaoVien.AllowUserToAddRows = false;
            dgvGiaoVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        

        }
        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien gv = new GiaoVien();
                gv.MaGiaoVien = txbMaGiaoVien.Text;
                gv.HoTen = txbHoTenGiaoVien.Text;
                if (rdbNamGV.Checked == true)
                    gv.GioiTinh = true;
                if (rdbNuGV.Checked == true)
                    gv.GioiTinh = false;
                gv.NgaySinh = dtpNgaySinhGV.Value;
                gv.ChuyenMon = txbChuyenMon.Text;
                gv.SDT = int.Parse(txbSoDienThoaiGV.Text.ToString());
                gv.DanToc = txbDanTocGV.Text;
                gv.DiaChi = txbDiaChiGV.Text;
                if (gv_bll.ThemGiaoVien(gv))
                    MessageBox.Show("Thêm giáo viên thành công");
                LoaddvgGiaoVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaGiaoVien_Click(object sender, EventArgs e)
        {
            if (txbMaGiaoVien.Text == "")
                MessageBox.Show("Vui lòng chọn đối tượng để xóa");
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gv_bll.XoaGiaoVien(txbMaGiaoVien.Text))
                    MessageBox.Show("Xóa thành công");
                LoaddvgGiaoVien();
            }
        }

        private void btnSuaGiaoVien_Click(object sender, EventArgs e)
        {

            try
            {
                GiaoVien gv = new GiaoVien();
                gv.MaGiaoVien = txbMaGiaoVien.Text;
                gv.HoTen = txbHoTenGiaoVien.Text;
                if (rdbNamGV.Checked == true)
                    gv.GioiTinh = true;
                if (rdbNuGV.Checked == true)
                    gv.GioiTinh = false;
                gv.NgaySinh = dtpNgaySinhGV.Value;
                gv.ChuyenMon = txbChuyenMon.Text;
                gv.SDT = int.Parse(txbSoDienThoaiGV.Text.ToString());
                gv.DanToc = txbDanTocGV.Text;
                gv.DiaChi = txbDiaChiGV.Text;

                if (gv_bll.SuaGiaoVien(gv))
                    MessageBox.Show("Sửa học sinh thành công");
                LoaddvgGiaoVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {

        }

        private void txbTimKiemHocSinh_TextChanged(object sender, EventArgs e)
        {

            {

                List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
                dsGiaoVien = gv_bll.TimKiemGiaoVien(txbTimKiemGiaoVien.Text);
                dgvGiaoVien.DataSource = dsGiaoVien;
                if (txbTimKiemGiaoVien.Text == "")
                {
                    LoaddvgGiaoVien();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvGiaoVien.SelectedRows[0];

                txbMaGiaoVien.Text = dr.Cells["MaGiaoVien"].Value.ToString();
                txbHoTenGiaoVien.Text = dr.Cells["HoTen"].Value.ToString();
                if (Boolean.Parse(dr.Cells["GioiTinh"].Value.ToString()) == true)
                    rdbNamGV.Checked = true;
                else
                    rdbNuGV.Checked = true;
                dtpNgaySinhGV.Value = DateTime.Parse(dr.Cells["NgaySinh"].Value.ToString());
                txbChuyenMon.Text = dr.Cells["ChuyenMon"].Value.ToString();
                txbSoDienThoaiGV.Text = dr.Cells["SDT"].Value.ToString();
                txbDanTocGV.Text = dr.Cells["DanToc"].Value.ToString();
                txbDiaChiGV.Text = dr.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
