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
    public class LichDay_DAL : DatabaseAccess
    {
        public List<LichDay> ThongTinLichDay()
        {
            List<LichDay> ttLichDay = new List<LichDay>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from thoiKhoaBieu";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LichDay ld = new LichDay();
                ld.MaTKB = reader.GetInt32(0);
                ld.MaLop = reader.GetString(1);
                ld.MaGiaoVien = reader.GetString(2);
                ld.MaMonHoc = reader.GetString(3);
                ld.Thu = reader.GetInt32(4);
                ld.Tiet_bd = reader.GetInt32(5);
                ld.Tiet_kt = reader.GetInt32(6);
                ld.NamHoc = reader.GetString(7);
                ld.MaHocKy = reader.GetString(8);

                ttLichDay.Add(ld);
            }
            reader.Close();
            return ttLichDay;
        }
        public bool ThemLichDay(LichDay ld)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into thoiKhoaBieu values(@maTKB,@lopma,@GVma, @monHocMa, @thu, @tu, @den, @namHoc,@hocKyMa)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maTKB", SqlDbType.Int).Value = ld.MaTKB;
            cmd.Parameters.Add("@lopma", SqlDbType.VarChar).Value = ld.MaLop;
            cmd.Parameters.Add("@GVma", SqlDbType.VarChar).Value = ld.MaGiaoVien;
            cmd.Parameters.Add("@monHocMa", SqlDbType.VarChar).Value = ld.MaMonHoc;
            cmd.Parameters.Add("@thu", SqlDbType.Int).Value = ld.Thu;
            cmd.Parameters.Add("@tu", SqlDbType.Int).Value = ld.Tiet_bd;
            cmd.Parameters.Add("@den", SqlDbType.Int).Value = ld.Tiet_kt;
            cmd.Parameters.Add("@namHoc", SqlDbType.NVarChar).Value = ld.NamHoc;
            cmd.Parameters.Add("@hocKyMa", SqlDbType.VarChar).Value = ld.MaHocKy;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool SuaLichDay(LichDay ld)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update thoiKhoaBieu set lopma=@lopma, GVma=@GVma, monHocMa=@monHocMa, thu=@thu, tu=@tu, den=@den, namHoc=@namHoc, hocKyMa=@hocKyMa where maTKB=@maTKB";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maTKB", SqlDbType.Int).Value = ld.MaTKB;
            cmd.Parameters.Add("@lopma", SqlDbType.VarChar).Value = ld.MaLop;
            cmd.Parameters.Add("@GVma", SqlDbType.VarChar).Value = ld.MaGiaoVien;
            cmd.Parameters.Add("@monHocMa", SqlDbType.VarChar).Value = ld.MaMonHoc;
            cmd.Parameters.Add("@thu", SqlDbType.Int).Value = ld.Thu;
            cmd.Parameters.Add("@tu", SqlDbType.Int).Value = ld.Tiet_bd;
            cmd.Parameters.Add("@den", SqlDbType.Int).Value = ld.Tiet_kt;
            cmd.Parameters.Add("@namHoc", SqlDbType.NVarChar).Value = ld.NamHoc;
            cmd.Parameters.Add("@hocKyMa", SqlDbType.VarChar).Value = ld.MaHocKy;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool XoaLichDay(int MaTKB)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from thoiKhoaBieu where MaTKB=@maTKB";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maTKB", SqlDbType.Int).Value = MaTKB;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public List<LichDay> TimKiemLichDay(int MaTKB)
        {
            List<LichDay> ttLichDay = new List<LichDay>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from thoiKhoaBieu where MaTKB= @maTKB";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maTKB", SqlDbType.Int).Value = MaTKB;
            //cmd.Parameters.Add("@lopma", SqlDbType.VarChar).Value = MaLop;
            //cmd.Parameters.Add("@GVMa", SqlDbType.VarChar).Value = MaGiaoVien;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LichDay ld = new LichDay();
                ld.MaTKB = reader.GetInt32(0);
                ld.MaLop = reader.GetString(2);
                ld.MaGiaoVien = reader.GetString(3);
                ld.MaMonHoc = reader.GetString(3);
                ld.Thu = reader.GetInt32(4);
                ld.Tiet_bd = reader.GetInt32(5);
                ld.Tiet_kt = reader.GetInt32(6);
                ld.NamHoc = reader.GetString(7);
                ld.MaHocKy = reader.GetString(8);

                ttLichDay.Add(ld);
            }
            reader.Close();
            return ttLichDay;
        }
    }
}
