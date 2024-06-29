using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        
        private void openFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_1"] == null)
            {
                frm_1 frm_1 = new frm_1();
                frm_1.MdiParent = this;
                frm_1.Show();
            }
            else Application.OpenForms["frm_1"].Activate();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_2"] == null)
            {
                frm_2 frm_2 = new frm_2();
                frm_2.MdiParent = this;
                frm_2.Show();
            }
            else Application.OpenForms["frm_2"].Activate();
        }

        private void closeForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
