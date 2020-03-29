namespace QL_BanHang.View
{
    partial class frmConfig
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Savebtt = new System.Windows.Forms.Button();
            this.Cancelbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server Name ";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(227, 69);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(212, 22);
            this.txtServer.TabIndex = 5;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(227, 110);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '*';
            this.txtDatabase.Size = new System.Drawing.Size(212, 22);
            this.txtDatabase.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(227, 152);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(212, 22);
            this.txtUser.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(227, 193);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(212, 22);
            this.txtPass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Window Authentication";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Savebtt
            // 
            this.Savebtt.Location = new System.Drawing.Point(55, 287);
            this.Savebtt.Name = "Savebtt";
            this.Savebtt.Size = new System.Drawing.Size(154, 48);
            this.Savebtt.TabIndex = 14;
            this.Savebtt.Text = "Save";
            this.Savebtt.UseVisualStyleBackColor = true;
            // 
            // Cancelbt
            // 
            this.Cancelbt.Location = new System.Drawing.Point(271, 287);
            this.Cancelbt.Name = "Cancelbt";
            this.Cancelbt.Size = new System.Drawing.Size(154, 48);
            this.Cancelbt.TabIndex = 15;
            this.Cancelbt.Text = "Cancel";
            this.Cancelbt.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 374);
            this.Controls.Add(this.Cancelbt);
            this.Controls.Add(this.Savebtt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Name = "frmConfig";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Savebtt;
        private System.Windows.Forms.Button Cancelbt;
    }
}