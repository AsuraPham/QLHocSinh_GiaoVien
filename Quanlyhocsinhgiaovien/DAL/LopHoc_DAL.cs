using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class LopHoc_DAL:DatabaseAccess
    {
        public List<LopHoc> LayDanhSachLopHoc()
        {
            List<LopHoc> dsLopHoc = new List<LopHoc>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lopHoc";
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                LopHoc lh = new LopHoc();
                lh.MaLop = reader.GetString(0);
                lh.TenLop = reader.GetString(1);
                lh.SiSo = reader.GetInt32(2);
                lh.MaKhoi = reader.GetString(3);
                dsLopHoc.Add(lh);
            }
            reader.Close();
            return dsLopHoc;            
        }
    }
}
