using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int matk, string tendn, string tenhienthi, int loaitk, string matkhau = null)
        {
            this.matk = matk;
            this.tendn = tendn;
            this.tenhienthi = tenhienthi;
            this.loaitk = loaitk;
            this.matkhau = matkhau;
        }
        public TaiKhoan(DataRow row)
        {
            //this.matk = (int)row["matk"];
            this.tendn = row["tendn"].ToString();
            this.tenhienthi = row["tenhienthi"].ToString();
            this.loaitk = (int)row["loaitk"];
            this.matkhau = row["matkhau"].ToString();
        }

        public int matk { get; set; }
        public string tendn { get; set; }
        public string tenhienthi { get; set; }
        public string matkhau { get; set; }
        public int loaitk { get; set; }
    }
}
