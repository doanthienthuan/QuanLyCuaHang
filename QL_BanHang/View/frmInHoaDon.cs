using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QL_BanHang.View
{
    public partial class frmInHoaDon : Form
    {
        private DataTable dt = new DataTable();
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        public frmInHoaDon(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            crpHoaDon pr_report = new crpHoaDon();
            pr_report.Database.Tables["HoaDon"].SetDataSource(dt);
            crvDataTable.ReportSource = null;
            crvDataTable.ReportSource = pr_report;
            crvDataTable.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
