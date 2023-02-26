namespace Đồ_Án_C_Shape
{
    partial class frmTaiKhoanDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoanDangNhap));
            this.txtNhapMK = new System.Windows.Forms.TextBox();
            this.pitDong = new System.Windows.Forms.PictureBox();
            this.txtNhapTK = new System.Windows.Forms.TextBox();
            this.LlblDangKi = new System.Windows.Forms.LinkLabel();
            this.LlblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.LblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnDangnhap = new Đồ_Án_C_Shape.Resources.btnDangnhap();
            this.chkAnHienMk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pitDong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNhapMK
            // 
            this.txtNhapMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhapMK.BackColor = System.Drawing.Color.White;
            this.txtNhapMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNhapMK.Location = new System.Drawing.Point(150, 332);
            this.txtNhapMK.Multiline = true;
            this.txtNhapMK.Name = "txtNhapMK";
            this.txtNhapMK.PasswordChar = '♥';
            this.txtNhapMK.Size = new System.Drawing.Size(249, 40);
            this.txtNhapMK.TabIndex = 1;
            // 
            // pitDong
            // 
            this.pitDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitDong.Image = global::Đồ_Án_C_Shape.Properties.Resources.Close2;
            this.pitDong.Location = new System.Drawing.Point(833, 3);
            this.pitDong.Name = "pitDong";
            this.pitDong.Size = new System.Drawing.Size(61, 36);
            this.pitDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pitDong.TabIndex = 7;
            this.pitDong.TabStop = false;
            this.pitDong.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNhapTK
            // 
            this.txtNhapTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhapTK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNhapTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNhapTK.Location = new System.Drawing.Point(150, 266);
            this.txtNhapTK.Multiline = true;
            this.txtNhapTK.Name = "txtNhapTK";
            this.txtNhapTK.Size = new System.Drawing.Size(249, 40);
            this.txtNhapTK.TabIndex = 0;
            // 
            // LlblDangKi
            // 
            this.LlblDangKi.AutoSize = true;
            this.LlblDangKi.BackColor = System.Drawing.Color.Transparent;
            this.LlblDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblDangKi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblDangKi.LinkColor = System.Drawing.Color.Cyan;
            this.LlblDangKi.Location = new System.Drawing.Point(134, 380);
            this.LlblDangKi.Name = "LlblDangKi";
            this.LlblDangKi.Size = new System.Drawing.Size(81, 22);
            this.LlblDangKi.TabIndex = 4;
            this.LlblDangKi.TabStop = true;
            this.LlblDangKi.Text = "Đăng Kí";
            this.LlblDangKi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblDangKi_LinkClicked);
            // 
            // LlblQuenMatKhau
            // 
            this.LlblQuenMatKhau.AutoSize = true;
            this.LlblQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.LlblQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblQuenMatKhau.ForeColor = System.Drawing.Color.White;
            this.LlblQuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblQuenMatKhau.LinkColor = System.Drawing.Color.Cyan;
            this.LlblQuenMatKhau.Location = new System.Drawing.Point(134, 414);
            this.LlblQuenMatKhau.Name = "LlblQuenMatKhau";
            this.LlblQuenMatKhau.Size = new System.Drawing.Size(143, 20);
            this.LlblQuenMatKhau.TabIndex = 2;
            this.LlblQuenMatKhau.TabStop = true;
            this.LlblQuenMatKhau.Text = "Quên MậT Khẩu";
            this.LlblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblQuenMatKhau_LinkClicked);
            // 
            // LblTaiKhoan
            // 
            this.LblTaiKhoan.AutoSize = true;
            this.LblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.LblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.LblTaiKhoan.Location = new System.Drawing.Point(12, 280);
            this.LblTaiKhoan.Name = "LblTaiKhoan";
            this.LblTaiKhoan.Size = new System.Drawing.Size(119, 26);
            this.LblTaiKhoan.TabIndex = 5;
            this.LblTaiKhoan.Text = "Tài Khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblMatKhau.Location = new System.Drawing.Point(12, 343);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(121, 29);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.White;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDangnhap.Location = new System.Drawing.Point(232, 448);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(132, 49);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // chkAnHienMk
            // 
            this.chkAnHienMk.AutoSize = true;
            this.chkAnHienMk.BackColor = System.Drawing.Color.Transparent;
            this.chkAnHienMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnHienMk.Location = new System.Drawing.Point(265, 381);
            this.chkAnHienMk.Name = "chkAnHienMk";
            this.chkAnHienMk.Size = new System.Drawing.Size(155, 24);
            this.chkAnHienMk.TabIndex = 14;
            this.chkAnHienMk.Text = "Hiện Mật Khẩu";
            this.chkAnHienMk.UseVisualStyleBackColor = false;
            this.chkAnHienMk.CheckedChanged += new System.EventHandler(this.chkAnHienMk_CheckedChanged);
            // 
            // frmTaiKhoanDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 572);
            this.Controls.Add(this.chkAnHienMk);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.LblTaiKhoan);
            this.Controls.Add(this.LlblQuenMatKhau);
            this.Controls.Add(this.LlblDangKi);
            this.Controls.Add(this.txtNhapTK);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.pitDong);
            this.Controls.Add(this.txtNhapMK);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoanDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Tài Khoản Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTaiKhoanDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pitDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapMK;
        private System.Windows.Forms.PictureBox pitDong;
        private Resources.btnDangnhap btnDangnhap;
        private System.Windows.Forms.TextBox txtNhapTK;
        private System.Windows.Forms.LinkLabel LlblDangKi;
        private System.Windows.Forms.LinkLabel LlblQuenMatKhau;
        private System.Windows.Forms.Label LblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.CheckBox chkAnHienMk;
    }
}

