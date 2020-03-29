namespace QL_BanHang.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QLNV = new System.Windows.Forms.Button();
            this.QLKH = new System.Windows.Forms.Button();
            this.BH = new System.Windows.Forms.Button();
            this.QLHH = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btDX = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLNV
            // 
            this.QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.QLNV.Location = new System.Drawing.Point(180, 67);
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(173, 168);
            this.QLNV.TabIndex = 0;
            this.QLNV.Text = "Quản Lý Nhân Viên";
            this.QLNV.UseVisualStyleBackColor = true;
            this.QLNV.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLKH
            // 
            this.QLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.QLKH.Location = new System.Drawing.Point(180, 253);
            this.QLKH.Name = "QLKH";
            this.QLKH.Size = new System.Drawing.Size(173, 168);
            this.QLKH.TabIndex = 1;
            this.QLKH.Text = "Khách Hàng";
            this.QLKH.UseVisualStyleBackColor = true;
            this.QLKH.Click += new System.EventHandler(this.QLKH_Click);
            // 
            // BH
            // 
            this.BH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BH.Location = new System.Drawing.Point(428, 253);
            this.BH.Name = "BH";
            this.BH.Size = new System.Drawing.Size(173, 168);
            this.BH.TabIndex = 2;
            this.BH.Text = "Bán Hàng";
            this.BH.UseVisualStyleBackColor = true;
            this.BH.Click += new System.EventHandler(this.BH_Click);
            // 
            // QLHH
            // 
            this.QLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLHH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.QLHH.Location = new System.Drawing.Point(428, 67);
            this.QLHH.Name = "QLHH";
            this.QLHH.Size = new System.Drawing.Size(173, 168);
            this.QLHH.TabIndex = 3;
            this.QLHH.Text = "Quản Lý Hàng Hóa";
            this.QLHH.UseVisualStyleBackColor = true;
            this.QLHH.Click += new System.EventHandler(this.QLHH_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(151, 20);
            this.status.Text = "toolStripStatusLabel1";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // btDX
            // 
            this.btDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDX.Location = new System.Drawing.Point(642, 385);
            this.btDX.Name = "btDX";
            this.btDX.Size = new System.Drawing.Size(179, 58);
            this.btDX.TabIndex = 5;
            this.btDX.Text = "Đăng xuất";
            this.btDX.UseVisualStyleBackColor = true;
            this.btDX.Click += new System.EventHandler(this.btDX_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 472);
            this.Controls.Add(this.btDX);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.QLHH);
            this.Controls.Add(this.BH);
            this.Controls.Add(this.QLKH);
            this.Controls.Add(this.QLNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QLNV;
        private System.Windows.Forms.Button QLKH;
        private System.Windows.Forms.Button BH;
        private System.Windows.Forms.Button QLHH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button btDX;
    }
}