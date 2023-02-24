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
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.llblQuenMK = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangnhap = new Đồ_Án_C_Shape.Resources.btnDangnhap();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTaiKhoan.Location = new System.Drawing.Point(19, 209);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(81, 16);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblMatKhau.Location = new System.Drawing.Point(26, 250);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(74, 16);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Tag = "♥";
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaikhoan.Location = new System.Drawing.Point(121, 206);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(179, 22);
            this.txtTaikhoan.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(121, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '♥';
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 4;
            // 
            // llblQuenMK
            // 
            this.llblQuenMK.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llblQuenMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblQuenMK.AutoSize = true;
            this.llblQuenMK.BackColor = System.Drawing.Color.Transparent;
            this.llblQuenMK.LinkColor = System.Drawing.Color.White;
            this.llblQuenMK.Location = new System.Drawing.Point(163, 337);
            this.llblQuenMK.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.llblQuenMK.Name = "llblQuenMK";
            this.llblQuenMK.Size = new System.Drawing.Size(97, 16);
            this.llblQuenMK.TabIndex = 6;
            this.llblQuenMK.TabStop = true;
            this.llblQuenMK.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Đồ_Án_C_Shape.Properties.Resources.Close2;
            this.pictureBox1.Location = new System.Drawing.Point(679, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.White;
            this.btnDangnhap.BackgroundColor = System.Drawing.Color.White;
            this.btnDangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangnhap.BorderRadius = 20;
            this.btnDangnhap.BorderSize = 0;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnDangnhap.Location = new System.Drawing.Point(132, 275);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(150, 40);
            this.btnDangnhap.TabIndex = 8;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.TextColor = System.Drawing.Color.SkyBlue;
            this.btnDangnhap.UseVisualStyleBackColor = false;
            // 
            // frmTaiKhoanDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 441);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llblQuenMK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoanDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Tài Khoản Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel llblQuenMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Resources.btnDangnhap btnDangnhap;
    }
}

