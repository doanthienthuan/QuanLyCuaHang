using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class frmMain : Form
    {
        string TenNhanVien = "", ChucVu = "";
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string TenNhanVien, string ChucVu)
        {
            InitializeComponent();
            this.TenNhanVien = TenNhanVien;
            this.ChucVu = ChucVu;
            this.status.Text = "Nhân viên đang làm việc  " + this.TenNhanVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChucVu == "CHT")
            {
                frmNhanVien nv = new frmNhanVien();
                nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải là cửa hàng trưởng mới thực hiện được chức năng này");
            }
        }

        private void QLHH_Click(object sender, EventArgs e)
        {
            if (ChucVu == "CHT")
            {
                frmHangHoa hh = new frmHangHoa();
                hh.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải là cửa hàng trưởng mới thực hiện được chức năng này");
            }
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void BH_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void btDX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmDangNhap fr1 = new frmDangNhap();
                this.Hide();
                fr1.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
