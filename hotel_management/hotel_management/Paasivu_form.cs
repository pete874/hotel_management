using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class PaasivuForm : Form
    {
        public PaasivuForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PaasivuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaat_form frm_as = new Asiakkaat_form();
            frm_as.Show();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset_form frm_va = new Varaukset_form();
            frm_va.Show();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huoneet_form frm_hu = new Huoneet_form();
            frm_hu.Show();
        }
    }
}
