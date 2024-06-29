using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        int saipass = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tdn = txt_TenDangNhap.Text.ToUpper();
            string pass = txt_MatKhau.Text;
            if (tdn == "A" && pass == "1")
            {
                saipass = 0;
                frm_QLSinhVien fr = new frm_QLSinhVien();
                fr.Show();
                this.Hide();
            }
            else
            {
                saipass++;
                MessageBox.Show($"Sai Pass lần {saipass}");                
                if (saipass == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai pass 3 lần, thoát ứng dụng");
                    Application.Exit();
                }
            }
            
            
            
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap = txt_MatKhau = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
