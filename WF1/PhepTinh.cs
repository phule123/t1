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
    public partial class frm_PhepTinh : Form
    {
        public frm_PhepTinh()
        {
            InitializeComponent();
        }
        private bool kiemtranhap(string a, string b)
        {
            float s1, s2;
            if (float.TryParse(a, out s1))
                if (float.TryParse(b, out s2))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Số B không đúng định dạng");
                    return false;
                }
            
            else MessageBox.Show("Số A không đúng định dạng");
            return false;

        }
        private void btn_Cong_Click(object sender, EventArgs e)
        {
            if (kiemtranhap(txt_SoA.Text, txt_SoB.Text))
            {
                float kq = 0;
                kq = float.Parse(txt_SoA.Text) + float.Parse(txt_SoB.Text);
                txt_KQ.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi nhập ký tự");
            }
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            try
            {
                float kq = 0;
                kq = float.Parse(txt_SoA.Text) - float.Parse(txt_SoB.Text);
                txt_KQ.Text = kq.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập ký tự");
            }
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                float kq = 0;
                kq = float.Parse(txt_SoA.Text) * float.Parse(txt_SoB.Text);
                txt_KQ.Text = kq.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập ký tự");
            }
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            try
            {
                float kq = 0;
                if(float.Parse(txt_SoB.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập mẫu số khác 0");
                }
                else
                {
                    kq = float.Parse(txt_SoA.Text) / float.Parse(txt_SoB.Text);
                    txt_KQ.Text = kq.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nhập ký tự");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
                Application.ExitThread();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_SoA.Text = txt_SoB.Text = txt_KQ.Text = null;
        }

        private void frm_PhepTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
