using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LopHoc_BLL
    {
        LopHoc_DAL lh_dal = new LopHoc_DAL();
        public List<LopHoc> LayDanhSachLopHoc()
        {
            return lh_dal.LayDanhSachLopHoc();
        }
    }
}
