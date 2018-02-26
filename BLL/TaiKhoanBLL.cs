using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taikhoan = new TaiKhoanDAL();
        public bool TaiKhoan(string tentk, string matkhau)
        {
            return taikhoan.TaiKhoan(tentk, matkhau);
        }
        public TaiKhoan LaytaikhautheoTendn(string tendn)
        {
            return taikhoan.LaytaikhautheoTendn(tendn);
        }
        public List<TaiKhoan> danhsachtaikhoan()
        {
            return taikhoan.danhsachtaikhoan();
        }
        public bool ThemTaiKhoan(string tendn, string tenhienthi, string matkhau, int loaitk)
        {
            return taikhoan.ThemTaiKhoan(tendn, tenhienthi, matkhau, loaitk);
        }
        public bool SuaTaiKhoan(string tendn, string tenhienthi, string matkhau, int loaitk, int matk)
        {
            return taikhoan.SuaTaiKhoan(tendn, tenhienthi, matkhau, loaitk, matk);
        }
        public bool XoaTaiKhoan(int matk)
        {
            return taikhoan.XoaTaiKhoan(matk);
        }
    }
}
