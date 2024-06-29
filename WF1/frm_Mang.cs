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
    public partial class frm_Mang : Form
    {
        public frm_Mang()
        {
            InitializeComponent();
            btn_tinh.Enabled = false;
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            string[] mangA = txt_mangA.Text.Split(' ');
            int tongchan = 0;
            int tongle = 0;
            int tongfull = 0;
            foreach(string item in mangA)
            {
                if (item != " " || item != "")
                {
                    int so = 0;
                    if(int.TryParse(item, out so))
                    {
                        tongfull += so;
                        if (so % 2 == 0) tongchan += so;
                        else tongle += so;
                    }
                }
            }
            txt_tongChan.Text = tongchan.ToString();
            txt_tongLe.Text = tongle.ToString();
            txt_tongfull.Text = tongfull.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mangA.Text = txt_tongChan.Text = txt_tongfull.Text = txt_tongLe.Text = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.ExitThread();
        }

        private void txt_mangA_TextChanged(object sender, EventArgs e)
        {
            btn_tinh.Enabled = true;
        }
    }
}
