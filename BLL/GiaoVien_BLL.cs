using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
   public class GiaoVien_BLL
    {
        GiaoVien_DAL gv_dal = new GiaoVien_DAL();
        public List<GiaoVien> LayThongTinGV()
        {
            return gv_dal.LaythongTinGv();
        }
        public bool ThemGiaoVien(GiaoVien gv)
        {
            return gv_dal.ThemGiaoVien(gv);
        }
        public bool XoaGiaoVien(string maGiaoVien)
        {
            return gv_dal.XoaGiaoVien(maGiaoVien);
        }
        public bool SuaGiaoVien(GiaoVien gv)
        {
            return gv_dal.SuaGiaoVien(gv);
        }
        public List<GiaoVien> TimKiemGiaoVien(string hoTen)
        {
            return gv_dal.TimKiemGiaoVien(hoTen);
        }
    }
}
