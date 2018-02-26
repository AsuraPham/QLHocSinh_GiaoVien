using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class HocSinh_BLL
    {
        HocSinh_DAL hs_dal = new HocSinh_DAL();
        public List<HocSinh> LayThongTinHocSinh(string maLop)
        {
            return hs_dal.LayThongTinHocSinh(maLop);
        }
        public bool ThemHocSinh(HocSinh hs)
        {
            return hs_dal.ThemHocSinh(hs);
        }
        public bool SuaHocSinh(HocSinh hs)
        {
            return hs_dal.SuaHocSinh(hs);
        }
        public bool XoaHocSinh(string maHocSinh)
        {
            return hs_dal.XoaHocSinh(maHocSinh);
        }
        public List<HocSinh> TimKiemHocSinh(string hoTen,string maLop)
        {
            return hs_dal.TimKiemHocSinh(hoTen, maLop);
        }
             
    }
}
