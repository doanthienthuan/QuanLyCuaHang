using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class HoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public string formatID(int ID) 
        {
            string result = "";
            if (ID < 10)
                result = "000" + ID.ToString();
            else if (ID < 100)
                result = "00" + ID.ToString();
            else if (ID < 1000)
                result = "0" + ID.ToString();
            else
                result = ID.ToString();
            return result;
        }
        public string AutoUpdateFK()
        {
            string result = "";
            DataTable dt = new DataTable();
            cmd.CommandText = "select top(1) MaHD from HoaDon order by MaHD desc";
            cmd.CommandType = CommandType.Text; 
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                String hd = dt.Rows[0][0].ToString();
                String hdD = hd.Substring(0, 8);
                string curD = DateTime.UtcNow.ToString("dd-MM-yyyy");
                curD = curD.Replace("-", "");
                int id = int.Parse(hd.Substring(8));
                if (curD.Equals(hdD))
                {
                    result = curD+ formatID(id + 1);
                }
                else
                {
                    result = curD + "0001";
                }
                
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return result;
        }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from HoaDon hd, KhachHang kh, NhanVien nv where kh.MaKH = hd.KhachHang and nv.MaNV = hd.NguoiLap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(HoaDonObj hdObj)
        {
            cmd.CommandText = "insert into HoaDon values ('" + hdObj.MaHoaDon + "', CONVERT (date,'" + hdObj.NgayLap + "'),'" + hdObj.NguoiLap + "','" + hdObj .KhachHang+ "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete from HoaDon Where MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
