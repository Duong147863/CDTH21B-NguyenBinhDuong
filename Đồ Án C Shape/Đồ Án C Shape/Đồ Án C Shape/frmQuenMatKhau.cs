using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_C_Shape
{
    public partial class frmQuenMatKhau : Form
    {
        bool isThoat = true;
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            frmTaiKhoanDangNhap TKDN=new frmTaiKhoanDangNhap();
            TKDN.Show();
        }

        private void frmQuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }
    }
}
