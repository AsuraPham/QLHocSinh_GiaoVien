using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public bool TaiKhoan(string tentk, string matkhau)
        {
            string query = "usp_TaiKhoan @tendn , @matkhau";
            DataTable result = DatabaseAccess.Instance.ExcuteQuery(query, new object[] { tentk, matkhau });
            return result.Rows.Count > 0;
        }
        public TaiKhoan LaytaikhautheoTendn(string tendn)
        {
            DataTable data = DatabaseAccess.Instance.ExcuteQuery("Select * from dangNhap where tendn = '" + tendn + "'");
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }
            return null;
        }
        public List<TaiKhoan> danhsachtaikhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = "select * from dangNhap";
            DataTable data = DatabaseAccess.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoan taikhoan = new TaiKhoan(item);
                list.Add(taikhoan);
            }
            return list;
        }
        public bool ThemTaiKhoan(string tendn, string tenhienthi, string matkhau, int loaitk)
        {
            string query = string.Format("insert dbo.dangNhap ( tendn, tenhienthi, matkhau, loaitk ) values ( N'{0}', N'{1}', N'{2}', {3})", tendn, tenhienthi, matkhau, loaitk);
            int result = DatabaseAccess.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool SuaTaiKhoan(string tendn, string tenhienthi, string matkhau, int loaitk, int matk)
        {
            string query = string.Format("UPDATE dbo.dangNhap SET tendn = N'{0}',tenhienthi = N'{1}', matkhau = N'{2}', loaitk = '{3}' where matk = '{4}'", tendn, tenhienthi, matkhau, loaitk, matk);
            int result = DatabaseAccess.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool XoaTaiKhoan(int matk)
        {
            string query = string.Format("Delete dangNhap where matk = '{0}'", matk);
            int result = DatabaseAccess.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
