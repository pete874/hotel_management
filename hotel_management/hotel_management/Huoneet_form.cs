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
    public partial class Huoneet_form : Form
    {
        HUONE huoneet = new HUONE();
        public Huoneet_form()
        {
            InitializeComponent();
        }

        private void Huoneet_form_Load(object sender, EventArgs e)
        {
            HuoneetDG.DataSource = huoneet.HaeHuoneet();

            HuoneTyyppiCB.DataSource = huoneet.HuoneTyyppiLista();
            HuoneTyyppiCB.DisplayMember = "huonetyyppi";
            HuoneTyyppiCB.ValueMember = "kategoriaid";
            
            
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNroTB.Text);
            int huonetyyppi = Convert.ToInt32(HuoneTyyppiCB.SelectedValue.ToString());
            String puhelin = PuhTB.Text;

            if (huoneet.LisaaHuone(huonenro, huonetyyppi, puhelin, "kylla"))
            {
                MessageBox.Show("Huone lisätty!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonen lisäys epäonnistui!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
