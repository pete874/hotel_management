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
        //tehdään HUONE classista huoneet instanssi
        HUONE huoneet = new HUONE();
        public Huoneet_form()
        {
            InitializeComponent();
        }

        //tänne sisään kaikki asiat jotka halutaan tapahtuvan heti formin latautuessa
        private void Huoneet_form_Load(object sender, EventArgs e)
        {
            //haetaan datagridiin tiedot HaeHuoneet funktiolla
            HuoneetDG.DataSource = huoneet.HaeHuoneet();

            //haetaan dropdown menuun tiedot huoneiden tyypeistä
            HuoneTyyppiCB.DataSource = huoneet.HuoneTyyppiLista();
            
            //valikossa näkyvä kenttä
            HuoneTyyppiCB.DisplayMember = "huonetyyppi";

            //value joka palautetaan kun valikosta valitaan jokin huonetyyppi
            HuoneTyyppiCB.ValueMember = "kategoriaid";
            
            
        }

        //Huoneen lisäys lisäysnappia painamalla
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNroTB.Text);
            int huonetyyppi = Convert.ToInt32(HuoneTyyppiCB.SelectedValue.ToString());
            String puhelin = PuhTB.Text;


            try
            {
                if (huoneet.LisaaHuone(huonenro, huonetyyppi, puhelin, "kylla"))
                {
                    MessageBox.Show("Huone lisätty!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonen lisäys epäonnistui!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe!" + ex.Message);
            }
            HuoneetDG.DataSource = huoneet.HaeHuoneet();
        }

        //Huoneen muokkaus muokkaa painiketta painamalla
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

        //Täytetään textikentät vastaamaan taulukosta painetun rivin tietoja
        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneNroTB.Text = HuoneetDG.CurrentRow.Cells[0].Value.ToString();
            HuoneTyyppiCB.SelectedValue = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PuhTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }

        //tyhjennä nappia painamalla tyhjennetään tekstikentät
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneNroTB.Text = "";
            HuoneTyyppiCB.SelectedIndex = 0;
            PuhTB.Text = "";
        }

        //poista nappia painamalla poistetaan huone huoneen numeron perusteella
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
