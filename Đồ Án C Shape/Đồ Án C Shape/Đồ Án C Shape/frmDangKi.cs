using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Đồ_Án_C_Shape
{
    public partial class frmDangKi : Form
    {
        bool isThoat = true;
        public frmDangKi()
        {
            InitializeComponent();
        }
        public bool CheckTK(string tk)//dùng để kiểm tra tk mk
        {

            return Regex.IsMatch(tk, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckMK(string mk)
        {

            return Regex.IsMatch(mk, "^[0-9]{6,24}$");
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            string tentk=txtNhapmk.Text;
            string mk=txtNhapmk.Text;
            string xnmk = txtXacNhanMatKhau.Text;
           
            if(!CheckTK(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6 đến 24 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapTk.Focus();
                return;
            }
            if (!CheckMK(mk))
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapmk.Focus();
                return;
            }
            if(xnmk!=mk)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }
            if(txtSoDienThoai.Text.Length!=10)
            {
                MessageBox.Show("Vui lòng nhập đủ 10 số điện thoại ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            frmTaiKhoanDangNhap TKDN = new frmTaiKhoanDangNhap();
            TKDN.Show();
        }

        private void frmDangKi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            Application.Exit();
        }
    }
}
