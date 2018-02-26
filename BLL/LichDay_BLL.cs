using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LichDay_BLL
    {
        LichDay_DAL ld_dal = new LichDay_DAL();
        public List<LichDay> ThongTinLichDay()
        {
            return ld_dal.ThongTinLichDay();
        }
        public bool ThemLichDay(LichDay ld)
        {
            return ld_dal.ThemLichDay(ld);
        }
        public bool SuaLichDay(LichDay ld)
        {
            return ld_dal.SuaLichDay(ld);
        }
        public bool XoaLichDay(int MaTKB)
        {
            return ld_dal.XoaLichDay(MaTKB);
        }
        public List<LichDay> TimKiemLichDay(int MaTKB)
        {
            return ld_dal.TimKiemLichDay(MaTKB);
        }
    }
}
