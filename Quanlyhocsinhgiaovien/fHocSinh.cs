using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace Quanlyhocsinhgiaovien
{
    public partial class fHocSinh : Form
    {
        public fHocSinh()
        {
            InitializeComponent();
            Load_CboHocSinh();
        }
        HocSinh_BLL hs_bll = new HocSinh_BLL();
        public void Load_CboHocSinh()
        {
            LopHoc_BLL lh_bll = new LopHoc_BLL();
            List<LopHoc> dsLopHoc = new List<LopHoc>();
            dsLopHoc = lh_bll.LayDanhSachLopHoc();
            foreach (var item in dsLopHoc)
            {
                string line = item.MaLop + ":" + item.TenLop;
                cbMalop.Items.Add(line);
            }
        }
        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = cbMalop.SelectedItem.ToString();
            string[] arr = line.Split(':');
            string maLop = arr[0];
            HienThiHocSinh(maLop);
        }
        private void HienThiHocSinh(string maLop)
        {
            List<HocSinh> dsHocSinh = hs_bll.LayThongTinHocSinh(maLop);
            dgvHocSinh.DataSource = dsHocSinh;
            dgvHocSinh.Columns[0].HeaderText = "Mã Lớp";
            dgvHocSinh.Columns[0].Visible = false;
            dgvHocSinh.Columns[1].HeaderText = "Mã Học Sinh";
            dgvHocSinh.Columns[1].Visible = false;
            dgvHocSinh.Columns[2].HeaderText = "Họ Tên";
            dgvHocSinh.Columns[3].HeaderText = "Giới Tính";
            dgvHocSinh.Columns[4].HeaderText = "Ngày Sinh";
            dgvHocSinh.Columns[5].HeaderText = "Dân Tộc";
            dgvHocSinh.Columns[6].HeaderText = "Địa Chỉ";
            dgvHocSinh.Columns[7].HeaderText = "Họ Tên Bố";
            dgvHocSinh.Columns[8].HeaderText = "Họ Tên Mẹ";
            dgvHocSinh.Columns[9].HeaderText = "Ghi Chú";
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
        
        }
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHocSinh.SelectedRows[0];
                txbMahocsinh.Text = row.Cells["MaHocSinh"].Value.ToString();
                txbHotenhocsinh.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaysinhhocsinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                if (Boolean.Parse(row.Cells["GioiTinh"].Value.ToString()) == true)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txbDiaChiHocSinh.Text = row.Cells["DiaChi"].Value.ToString();
                txbDantoc.Text = row.Cells["DanToc"].Value.ToString();
                txbHoTenMe.Text = row.Cells["HoTenMe"].Value.ToString();
                txbHoTenBo.Text = row.Cells["HoTenBo"].Value.ToString();
                txbGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {

            try
            {
                //lấy mã lớp
                string line = cbMalop.SelectedItem.ToString();
                string[] arr = line.Split(':');
                string maLop = arr[0];
                //tạo đối tượng cần thêm
                HocSinh hs = new HocSinh();
                hs.MaHocSinh = txbMahocsinh.Text;
                hs.MaLop = maLop;
                hs.HoTen = txbHotenhocsinh.Text;
                if (rdbNam.Checked == true)
                    hs.GioiTinh = true;
                if (rdbNu.Checked == true)
                    hs.GioiTinh = false;
                hs.NgaySinh = dtpNgaysinhhocsinh.Value;
                hs.DiaChi = txbDiaChiHocSinh.Text;
                hs.DanToc = txbDantoc.Text;
                hs.HoTenBo = txbHoTenBo.Text;
                hs.HoTenMe = txbHoTenMe.Text;
                hs.GhiChu = txbGhiChu.Text;

                if (hs_bll.ThemHocSinh(hs))
                    MessageBox.Show("Thêm học sinh thành công");
                HienThiHocSinh(maLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra nhập dữ liệu\n"+ex.Message);
            }
        }
        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy mã lớp
                string line = cbMalop.SelectedItem.ToString();
                string[] arr = line.Split(':');
                string maLop = arr[0];
                //thay đổi thông tin học sinh
                HocSinh hs = new HocSinh();
                hs.MaHocSinh = txbMahocsinh.Text;
                hs.MaLop = maLop;
                hs.HoTen = txbHotenhocsinh.Text;
                if (rdbNam.Checked == true)
                    hs.GioiTinh = true;
                if (rdbNu.Checked == true)
                    hs.GioiTinh = false;
                hs.NgaySinh = dtpNgaysinhhocsinh.Value;
                hs.DiaChi = txbDiaChiHocSinh.Text;
                hs.DanToc = txbDantoc.Text;
                hs.HoTenBo = txbHoTenBo.Text;
                hs.HoTenMe = txbHoTenMe.Text;
                hs.GhiChu = txbGhiChu.Text;

                if (hs_bll.SuaHocSinh(hs))
                    MessageBox.Show("Sửa học sinh thành công");
                HienThiHocSinh(maLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy mã lớp
                string line = cbMalop.SelectedItem.ToString();
                string[] arr = line.Split(':');
                string maLop = arr[0];
                //thực hiện xóa học sinh
                if (dgvHocSinh.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn đối tượng để xóa");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (hs_bll.XoaHocSinh(txbMahocsinh.Text))
                            MessageBox.Show("Xóa thành công");
                    HienThiHocSinh(maLop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txbTimKiemHocSinh_TextChanged(object sender, EventArgs e)
        {
            if (cbMalop.SelectedIndex > -1)
            {
                string line = cbMalop.SelectedItem.ToString();
                string[] arr = line.Split(':');
                string maLop = arr[0];
                List<HocSinh> dsHocSinh = new List<HocSinh>();
                dsHocSinh = hs_bll.TimKiemHocSinh(txbTimKiemHocSinh.Text, maLop);
                dgvHocSinh.DataSource = dsHocSinh;
                if (txbTimKiemHocSinh.Text == "")
                {
                    HienThiHocSinh(maLop);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã lớp");
            }
        }

        private void btnTimKiemHS_Click(object sender, EventArgs e)
        {

        }
    }
}
