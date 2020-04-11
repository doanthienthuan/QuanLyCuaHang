using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;
using QL_BanHang.View;
namespace QL_BanHang.View
{
    public partial class frmHoaDon : Form
    {
        KhachHangCtr khCtr = new KhachHangCtr();
        HoaDonCtr hdCtr = new HoaDonCtr();
        ChiTietCtr ctCtr = new ChiTietCtr();
        HangHoaCtr hhctr = new HangHoaCtr();    
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;
        
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            TongTientxt.Text = "0";
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;
        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource,"MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }

        //private void bingding1()
        //{
        //    txtDonGia.DataBindings.Clear();
        //    txtDonGia.DataBindings.Add("Text", dtgvDSHH.DataSource, "DonGia");
        //    txtSL.DataBindings.Clear();
        //    txtSL.DataBindings.Add("Text", dtgvDSHH.DataSource, "SoLuong");
        //    cmbHH.DataBindings.Clear();
        //    cmbHH.DataBindings.Add("Text", dtgvDSHH.DataSource, "HangHoa");
        //    lbThanhTien.DataBindings.Clear();
        //    lbThanhTien.DataBindings.Add("Text", dtgvDSHH.DataSource, "ThanhTien");

        //}

        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVien.Enabled = e;
            cmbKhachHang.Enabled = e;
            btnAdd.Enabled = !e;
            btnDel.Enabled = !e;
            btnPrint.Enabled = !e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btncham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbHH.Enabled = e;
            txtSL.Enabled = e;
        }

        private void LoadcmbKhachHang()
        { 
            KhachHangCtr khctr = new KhachHangCtr();
            cmbKhachHang.DataSource = khctr.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.SelectedIndex = 0;
        }

        private void LoadcmbHH()
        {
            HangHoaCtr hhctr = new HangHoaCtr();
            cmbHH.DataSource = hhctr.GetData();
            cmbHH.DisplayMember = "TenHang";
            cmbHH.ValueMember = "MaHang";
            
        }

        private void clearData()
        {
            txtMa.Text = hdCtr.AutoUpdateFK();
            txtNhanVien.Text = frmDangNhap.MSNV;
            txtNgayLap.Text = DateTime.Now.ToString();
            LoadcmbKhachHang();
            
        }

        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = txtNhanVien.Text.Trim();
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString().Trim();
        }

        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString())+SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia*soluong).ToString();
                    break;
                }
        }

        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaHang = '" + cmbHH.SelectedValue.ToString() + "' and SoLuong>= "+sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSHH.DataSource = dt;
                
            }
            catch
            {
                dtgvDSHH.DataSource = null;
            }
            //bingding1();
        }

        private void dtgvDSHH_DataSourceChanged(object sender, EventArgs e)
        {
            //bingding1();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbHH();
            LoadcmbKhachHang();

            
            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("HangHoa");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
            dtgvDSHH.DataSource = dtDSCT;
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDSCT.Rows.Count > 0)
            {
                KhachHangObj khObj = new KhachHangObj(cmbKhachHang.SelectedValue.ToString().Trim(),Int32.Parse(Diemtxt.Text));
                khCtr.UpdDiem(khObj);
                HoaDonObj hdObj = new HoaDonObj();
                addData(hdObj);
                if (hdCtr.AddData(hdObj))
                {
                    if (ctCtr.AddData(dtDSCT) && hhctr.UpdSL(dtDSCT))
                        MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmHoaDon_Load(sender, e);
                
            }
            else
            {
                MessageBox.Show("Hóa đơn không được rỗng!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmHoaDon_Load(sender, e);
            }

            else
                return;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInHoaDon fr1 = new frmInHoaDon(dtDSCT);
            fr1.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (!string.IsNullOrEmpty(txtMa.Text))
            {
                if(kiemtraSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text.Trim())))
                {
                    if (!checktrung(cmbHH.SelectedValue.ToString()))
                    {
                        try
                        {
                            DataRow dr = dtDSCT.NewRow();
                            dr[0] = txtMa.Text.Trim();
                            dr[1] = cmbHH.SelectedValue.ToString();
                            dr[2] = txtDonGia.Text;
                            dr[3] = txtSL.Text;
                            dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
                            dtDSCT.Rows.Add(dr);
                        } catch
                        {
                            MessageBox.Show("Hãy chọn hàng hóa trước khi thêm");
                        }
                    }
                    else
                    {
                        capnhatSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text));
                    }
                dtgvDSHH.DataSource = dtDSCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSL.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMa.Focus();
            }
            for(int i = 0; i < dtDSCT.Rows.Count; i++)
            {

                sum += int.Parse(dtDSCT.Rows[i][4].ToString());
            }
            TongTientxt.Text = sum.ToString();
            Diemtxt.Text = (sum / 10000).ToString();
            txtTongDiem.Text = (Int32.Parse(Diemtxt.Text) + Int32.Parse(txtKhDiem.Text)).ToString();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSHH.DataSource = dtDSCT;
            }
        }

        private void cmbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaHang = '" + cmbHH.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][2].ToString());

                txtDonGia.Text = (gia * 1.1).ToString();

                lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
            }
        }

        private void dtgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriclick = e.RowIndex;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbThanhTien_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDSHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbThanhTien_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKhDiem.Text = khCtr.GetDiem(cmbKhachHang.SelectedValue.ToString().Trim()).ToString();
        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
