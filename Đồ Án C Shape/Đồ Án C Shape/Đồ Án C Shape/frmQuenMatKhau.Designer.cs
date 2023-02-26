namespace Đồ_Án_C_Shape
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoDienThoaiDangKi = new System.Windows.Forms.Label();
            this.TxtSoDienThoaiDangKi = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnMatKhauLayLai = new Đồ_Án_C_Shape.Resources.btnDangnhap();
            this.btnQuayLai = new Đồ_Án_C_Shape.Resources.btnDangnhap();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoDienThoaiDangKi
            // 
            this.lblSoDienThoaiDangKi.AutoSize = true;
            this.lblSoDienThoaiDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiDangKi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoDienThoaiDangKi.Location = new System.Drawing.Point(82, 208);
            this.lblSoDienThoaiDangKi.Name = "lblSoDienThoaiDangKi";
            this.lblSoDienThoaiDangKi.Size = new System.Drawing.Size(143, 22);
            this.lblSoDienThoaiDangKi.TabIndex = 11;
            this.lblSoDienThoaiDangKi.Text = "Tên Tài Khoản";
            // 
            // TxtSoDienThoaiDangKi
            // 
            this.TxtSoDienThoaiDangKi.Location = new System.Drawing.Point(231, 196);
            this.TxtSoDienThoaiDangKi.Multiline = true;
            this.TxtSoDienThoaiDangKi.Name = "TxtSoDienThoaiDangKi";
            this.TxtSoDienThoaiDangKi.Size = new System.Drawing.Size(350, 44);
            this.TxtSoDienThoaiDangKi.TabIndex = 12;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKetQua.Location = new System.Drawing.Point(142, 275);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(83, 22);
            this.lblKetQua.TabIndex = 13;
            this.lblKetQua.Text = "Kết Quả";
            // 
            // btnMatKhauLayLai
            // 
            this.btnMatKhauLayLai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMatKhauLayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatKhauLayLai.ForeColor = System.Drawing.Color.Cyan;
            this.btnMatKhauLayLai.Location = new System.Drawing.Point(221, 310);
            this.btnMatKhauLayLai.Name = "btnMatKhauLayLai";
            this.btnMatKhauLayLai.Size = new System.Drawing.Size(168, 58);
            this.btnMatKhauLayLai.TabIndex = 14;
            this.btnMatKhauLayLai.Text = "Lấy Lại Mật Khẩu";
            this.btnMatKhauLayLai.UseVisualStyleBackColor = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Cyan;
            this.btnQuayLai.Location = new System.Drawing.Point(412, 310);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(168, 58);
            this.btnQuayLai.TabIndex = 15;
            this.btnQuayLai.Text = "QuayLai";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnMatKhauLayLai);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.TxtSoDienThoaiDangKi);
            this.Controls.Add(this.lblSoDienThoaiDangKi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuenMatKhau_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSoDienThoaiDangKi;
        private System.Windows.Forms.TextBox TxtSoDienThoaiDangKi;
        private System.Windows.Forms.Label lblKetQua;
        private Resources.btnDangnhap btnMatKhauLayLai;
        private Resources.btnDangnhap btnQuayLai;
    }
}