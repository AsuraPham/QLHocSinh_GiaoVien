using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class GiaoVien_DAL : DatabaseAccess
    {
        public List<GiaoVien> LaythongTinGv()
        {
            List<GiaoVien> DsGV = new List<GiaoVien>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from giaoVien";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GiaoVien gv = new GiaoVien();
                gv.MaGiaoVien = reader.GetString(0);
                gv.HoTen = reader.GetString(1);
                gv.GioiTinh = reader.GetBoolean(2);

                gv.NgaySinh = reader.GetDateTime(3);
                gv.ChuyenMon = reader.GetString(4);
                gv.SDT = reader.GetInt32(5);
                gv.DanToc = reader.GetString(6);
                gv.DiaChi = reader.GetString(7);

                DsGV.Add(gv);
            }
            reader.Close();
            return DsGV;
        }
        public bool ThemGiaoVien(GiaoVien gv)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into giaoVien values(@maGV,@hoTen,@gioiTinh,@ngaySinh,@chuyenMôn,@SDT,@danToc,@diaChi)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maGV", SqlDbType.VarChar).Value = gv.MaGiaoVien;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = gv.HoTen;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = gv.GioiTinh;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = gv.NgaySinh;
            cmd.Parameters.Add("@chuyenMôn", SqlDbType.NVarChar).Value = gv.ChuyenMon;
            cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = gv.SDT;
            cmd.Parameters.Add("@danToc", SqlDbType.NVarChar).Value = gv.DanToc;
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = gv.DiaChi;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool XoaGiaoVien(string maGiaoVien)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from giaoVien where maGV=@maGV";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maGV", SqlDbType.VarChar).Value = maGiaoVien;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaGiaoVien(GiaoVien gv)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update giaoVien set hoTen=@hoTen,gioiTinh=@gioiTinh,ngaySinh=@ngaySinh,chuyenMôn=@chuyenMôn,SDT=@SDT,danToc=@danToc,diaChi=@diaChi where maGV=@maGV";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maGV", SqlDbType.VarChar).Value = gv.MaGiaoVien;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = gv.HoTen;

            cmd.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = gv.GioiTinh;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = gv.NgaySinh;
            cmd.Parameters.Add("@chuyenMôn", SqlDbType.NVarChar).Value = gv.ChuyenMon;
            cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = gv.SDT;
            cmd.Parameters.Add("@danToc", SqlDbType.NVarChar).Value = gv.DanToc;
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = gv.DiaChi;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public List<GiaoVien> TimKiemGiaoVien(string hoTen)
        {
            List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from giaoVien where hoTen like N'%'+@hoTen+'%' ";
            cmd.Connection = conn;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GiaoVien gv = new GiaoVien();
                gv.MaGiaoVien = reader.GetString(0);
                gv.HoTen = reader.GetString(1);
                gv.GioiTinh = reader.GetBoolean(2);

                gv.NgaySinh = reader.GetDateTime(3);
                gv.ChuyenMon = reader.GetString(4);
                gv.SDT = reader.GetInt32(5);
                gv.DanToc = reader.GetString(6);
                gv.DiaChi = reader.GetString(7);

                dsGiaoVien.Add(gv);

            }
            reader.Close();
            return dsGiaoVien;

        }
    }
}
