using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_BanHang.Obiect;
using QL_BanHang.Model;
using QL_BanHang.View;

namespace QL_BanHang
{
    
    public partial class frmDangNhap : Form
    {
        public static string MSNV = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public DataTable checkLog(string user , string pass)
        {
            ConnectToSQL con = new ConnectToSQL();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "select *  from NhanVien where MaNV = '"+user+"' and MatKhau = '"+pass+"'";
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
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDn_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = checkLog(this.txtMa.Text, this.txtMatKhau.Text);
            if(dt.Rows.Count > 0)
            {
                MSNV = dt.Rows[0][0].ToString();
                frmMain frm1 = new frmMain(dt.Rows[0][1].ToString(),dt.Rows[0][7].ToString());
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
                //MessageBox.Show();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
