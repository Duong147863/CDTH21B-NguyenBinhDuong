using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Utils.Layout;


namespace Đồ_Án_C_Shape
{
    public partial class frmTaiKhoanDangNhap : Form
    {
       

        bool isThoat=true;
        public frmTaiKhoanDangNhap()
        {
           
            
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                 this.Close();
                
        }



        
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNhapTK.Text)||string.IsNullOrEmpty(txtNhapMK.Text))
            {
                MessageBox.Show("Xin vui lòng nhập tài khoản và mật khẩu đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            SqlConnection strCon = new SqlConnection(@"Data Source=LAPTOP-IHNRAJ0N\SQLEXPRESS;Initial Catalog=QuanLiBanGiay;Integrated Security=True");
            try
            {
                strCon.Open();
                string tk = txtNhapTK.Text;
                string mk = txtNhapMK.Text;
                string sql = "select * from TAIKHOAN where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, strCon);
                SqlDataReader data = cmd.ExecuteReader();
         

                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    txtNhapTK.Clear();
                    txtNhapMK.Clear();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại ");
                }


            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối");
            }
          
        }



        private void LlblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isThoat = false;
            frmQuenMatKhau quenMatKhau= new frmQuenMatKhau();//dùng để hiện ra form Quên mật khẩu
            quenMatKhau.Show();
            this.Hide();
        }

        private void LlblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isThoat=false;
            frmDangKi dangKi= new frmDangKi();
            dangKi.Show();
            this.Hide();
        }

       

        private void chkAnHienMk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnHienMk.Checked)
            {
                if (txtNhapMK.PasswordChar == '♥')
                {
                    chkAnHienMk.BringToFront();
                    txtNhapMK.PasswordChar = '\0';

                }
            }
            if(chkAnHienMk.Checked==false)
            {
                if (txtNhapMK.PasswordChar == '\0')
                {
                    chkAnHienMk.BringToFront();
                    txtNhapMK.PasswordChar = '♥';

                }
            }
                    
                }

        private void frmTaiKhoanDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
                Application.Exit();
        }
    }
    }
    
