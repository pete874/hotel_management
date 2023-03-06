using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class KirjauduForm : Form
    {
        public KirjauduForm()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            if (KayttajatunnusTB.Text == "admin" && SalasanaTB.Text == "admin")
            {
                PaasivuForm frm1 = new PaasivuForm();
                frm1.Show();
                this.Hide();
            }

            else
            {
                VirheviestiLB.Visible = true;
            }

         
        }
    }
}
