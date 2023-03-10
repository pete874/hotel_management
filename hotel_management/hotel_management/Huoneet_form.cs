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
            HuoneetDG.DataSource = huoneet.HaeHuoneet();
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            int huonetyyppi = Convert.ToInt32(HuoneTyyppiCB.SelectedValue.ToString());
            String puhelin = PuhTB.Text;
            String vapaa = "";
            int huonenro = Convert.ToInt32(HuoneNroTB.Text);

            if (KyllaRB.Checked)
            {
                vapaa = "kylla";
            }
            else
            {
                vapaa = "ei";
            }
            
            if (huoneet.MuokkaaHuone(huonenro, huonetyyppi, puhelin, vapaa))
            {
                MessageBox.Show("Muokkaus onnistui", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen muokkaus epäonnistui!", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huoneet.HaeHuoneet();
        }

        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneNroTB.Text = HuoneetDG.CurrentRow.Cells[0].Value.ToString();
            HuoneTyyppiCB.SelectedValue = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PuhTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneNroTB.Text = "";
            HuoneTyyppiCB.SelectedIndex = 0;
            PuhTB.Text = "";
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNroTB.Text);
            if (huoneet.PoistaHuone(huonenro))
            {
                MessageBox.Show("Huone poistettu", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen poistaminen epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
            HuoneetDG.DataSource = huoneet.HaeHuoneet();

        }
    }
}
