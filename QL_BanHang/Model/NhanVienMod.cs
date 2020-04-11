using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class NhanVienMod
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
            cmd.CommandText = "select top(1) MaNV from NhanVien";
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
            cmd.CommandText = "select *  from NhanVien";
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

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into NhanVien values ('" + nvObj.MaNhanVien + "',N'" + nvObj.TenNhanVien + "',N'" + nvObj.GioiTinh + "',N'" + nvObj.DiaChi + "','" + nvObj.DienThoai +"',CONVERT(DATE,'"+ nvObj.NamSinh +"',103),'"+nvObj.MatKhau+"','NV')";
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
        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set TenNV =  N'" + nvObj.TenNhanVien + "', GioiTinh = N'" + nvObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + nvObj.NamSinh + "',103), DiaChi = N'" + nvObj.DiaChi + "',SDT = '" + nvObj.DienThoai + "',MatKhau = '" + nvObj.MatKhau + "' Where MaNV = '" + nvObj.MaNhanVien + "'";
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

        public bool UpdMK(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set MatKhau ='" +nvObj.MatKhau+ "' Where MaNV = '" + nvObj.MaNhanVien + "'";
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
        public bool SetChucVu(string ChucVu, string MaNV)
        {
            if (ChucVu == "CHT" || ChucVu == "NV")
            {
                cmd.CommandText = "Update ChucVu from NhanVien Where MaNV = '" + MaNV + "'";
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
            else
            {
                return false;
            }
        }
        public bool DelData(string ma)
        {
            cmd.CommandText =  "Delete NhanVien Where MaNV = '" + ma + "'";
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
