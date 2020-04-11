using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class KhachHangMod
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
            cmd.CommandText = "select top(1) MaKH from KhachHang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                String hd = dt.Rows[0][0].ToString();
                int id = int.Parse(hd);
                result = formatID(id + 1);
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
            cmd.CommandText = "select MaKH, TenKH, GioiTinh,NamSinh,DiaChi,SDT,Email,Diem from KhachHang";
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

        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "Insert into KhachHang values ('" + khObj.MaKhachHang + "',N'" + khObj.TenKhachHang + "',N'" + khObj.GioiTinh + "',CONVERT(DATE,'" + khObj.NamSinh + "'),N'" + khObj.DienThoai + "',N'" + khObj.DiaChi + "',0,'"+ khObj.Email + "')";
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

        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "Update KhachHang set TenKH =  N'" + khObj.TenKhachHang + "', GioiTinh = N'" + khObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + khObj.NamSinh + "'), DiaChi = N'" + khObj.DiaChi + "',SDT = '" + khObj.DienThoai + "',Email = '" + khObj.Email + "',Diem = '" + khObj.Diem + "' Where MaKH = '" + khObj.MaKhachHang + "'";
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

        public bool UpdDiem(KhachHangObj khObj)
        {
            cmd.CommandText = "Update KhachHang set Diem ='" + khObj.Diem + "' Where MaKH = '" + khObj.MaKhachHang + "'";
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
            cmd.CommandText = "Delete KhachHang Where MaKH = '" + ma + "'";
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
        public int GetDiem(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select Diem from KhachHang Where MaKH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                int diem = Int32.Parse(dt.Rows[0][0].ToString());
                return diem;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return -1;
        }
    }
}
