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
    public class HocSinh_DAL : DatabaseAccess
    {
        public List<HocSinh> LayThongTinHocSinh(string maLop)
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from hocSinh where lopMa=@malop";
            cmd.Connection = conn;
            cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = maLop;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HocSinh hs = new HocSinh();
                hs.MaHocSinh = reader.GetString(0);
                hs.MaLop = reader.GetString(1);
                hs.HoTen = reader.GetString(2);
                hs.GioiTinh = reader.GetBoolean(3);
                hs.NgaySinh = reader.GetDateTime(4);
                hs.DanToc = reader.GetString(5);
                hs.DiaChi = reader.GetString(6);
                hs.HoTenBo = reader.GetString(7);
                hs.HoTenMe = reader.GetString(8);
                hs.GhiChu = reader.GetString(9);
                dsHocSinh.Add(hs);
            }
            reader.Close();
            return dsHocSinh;
        }
        public bool ThemHocSinh(HocSinh hs)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into hocSinh values(@maHs,@maLop,@hoTen,@gioiTinh,@ngaySinh,@danToc,@diaChi,@hoTenBo,@hoTenMe,@ghiChu)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maHs", SqlDbType.VarChar).Value = hs.MaHocSinh;
            cmd.Parameters.Add("@maLop", SqlDbType.VarChar).Value = hs.MaLop;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hs.HoTen;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = hs.NgaySinh;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = hs.GioiTinh;
            cmd.Parameters.Add("@danToc", SqlDbType.NVarChar).Value = hs.DanToc;
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = hs.DiaChi;
            cmd.Parameters.Add("@hoTenBo", SqlDbType.NVarChar).Value = hs.HoTenBo;
            cmd.Parameters.Add("@hoTenMe", SqlDbType.NVarChar).Value = hs.HoTenMe;
            cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = hs.GhiChu;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaHocSinh(HocSinh hs)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update hocSinh set lopMa=@maLop,hoTen=@hoTen,gioiTinh=@gioiTinh,ngaySinh=@ngaySinh,danToc=@danToc,diaChi=@diaChi,hoTenBo=@hoTenBo,hoTenMe=@hoTenMe,ghiChu=@ghiChu where maHocSinh=@maHS";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maHS", SqlDbType.VarChar).Value = hs.MaHocSinh;
            cmd.Parameters.Add("@maLop", SqlDbType.VarChar).Value = hs.MaLop;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hs.HoTen;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = hs.NgaySinh;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = hs.GioiTinh;
            cmd.Parameters.Add("@danToc", SqlDbType.NVarChar).Value = hs.DanToc;
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = hs.DiaChi;
            cmd.Parameters.Add("@hoTenBo", SqlDbType.NVarChar).Value = hs.HoTenBo;
            cmd.Parameters.Add("@hoTenMe", SqlDbType.NVarChar).Value = hs.HoTenMe;
            cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = hs.GhiChu;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool XoaHocSinh(string maHocSinh)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from hocSinh where maHocSinh=@maHocSinh";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public List<HocSinh> TimKiemHocSinh(string hoTen,string maLop)
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from hocSinh where hoTen like N'%'+@hoTen+'%' and lopMa=@malop";
            cmd.Connection = conn;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = maLop;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HocSinh hs = new HocSinh();
                hs.MaHocSinh = reader.GetString(0);
                hs.MaLop = reader.GetString(1);
                hs.HoTen = reader.GetString(2);
                hs.GioiTinh = reader.GetBoolean(3);
                hs.NgaySinh = reader.GetDateTime(4);
                hs.DanToc = reader.GetString(5);
                hs.DiaChi = reader.GetString(6);
                hs.HoTenBo = reader.GetString(7);
                hs.HoTenMe = reader.GetString(8);
                hs.GhiChu = reader.GetString(9);
                dsHocSinh.Add(hs);
            }
            reader.Close();
            return dsHocSinh;
        }
    }
}
