using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class frm_ListBox : Form
    {
        public frm_ListBox()
        {
            InitializeComponent();
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            for(int i = Lib_A.SelectedItems.Count - 1; i >= 0 ; i--)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
                Lib_A.Items.Remove(Lib_A.SelectedItems[i]);
            }
            Lib_A.Sorted = true;
            Lib_B.Sorted = true;
            
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            for (int i = Lib_A.Items.Count - 1; i >= 0; i--)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
            }
            Lib_A.Items.Clear();
            Lib_B.Sorted = true;
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
            Lib_A.Sorted = true;
            Lib_B.Sorted = true;
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.Items.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
            }
            Lib_B.Items.Clear();
            Lib_A.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib_A.Items.Clear();
            foreach(string ht in ho[comboBox1.SelectedItem.ToString()])
            {
                Lib_A.Items.Add(ht);
            }
        }
        Dictionary<string, string[]> ho = new Dictionary<string, string[]>();
        private void frm_ListBox_Load(object sender, EventArgs e)
        {
            ho.Add("Lê", new string[] { "Lê Văn A", "Lê Văn B", "Lê Văn C" });
            ho.Add("Nguyễn", new string[] { "Nguyễn Văn E", "Nguyễn Văn B", "Nguyễn Văn C" });
            ho.Add("Trần", new string[] { "Trần Văn F", "Trần Văn B", "Trần Văn C" });
            foreach(string t in ho.Keys)
            {
                comboBox1.Items.Add(t);
            }
        }

    }
}
