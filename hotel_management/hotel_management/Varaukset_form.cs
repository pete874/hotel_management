using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_management
{
    public partial class Varaukset_form : Form
    {
        //varauksissa käytetään seuraavia classeja, joista tehdään instanssit
        VARAUS varaukset = new VARAUS();
        HUONE huoneet = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        public Varaukset_form()
        {
            InitializeComponent();
        }

        //tänne sisään kaikki asiat jotka halutaan tapahtuvan heti formin latautuessa
        private void Varaukset_form_Load(object sender, EventArgs e)
        {
            //datetimepickerille custom format
            SisaanDTP.CustomFormat = "dd.MM.yyyy";
            SisaanDTP.Format = DateTimePickerFormat.Custom;

            UlosDTP.CustomFormat = "dd.MM.yyyy";
            UlosDTP.Format = DateTimePickerFormat.Custom;

            //täytetään datagrid HaeVaraukset funktiolla
            VarauksetDG.DataSource = varaukset.HaeVaraukset();

            //alla lisätään jokaiseen kolmeen comboboxiin tiedot
            HuonetyyppiCB.DataSource = huoneet.HuoneTyyppiLista();
            HuonetyyppiCB.DisplayMember = "huonetyyppi";
            HuonetyyppiCB.ValueMember = "huonetyyppi";

            TyontekijaCB.DataSource = asiakas.AsiakasLista();
            TyontekijaCB.DisplayMember = "FullName";
            TyontekijaCB.ValueMember = "FullName";

            HuonenroCB.DataSource = huoneet.HaeHuoneet();
            HuonenroCB.DisplayMember = "huonenro";
            HuonenroCB.ValueMember = "huonenro";
           
        }

        //Täytetään textikentät vastaamaan taulukosta painetun rivin tietoja
        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausnroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            TyontekijaCB.SelectedValue = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            HuonetyyppiCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            HuonenroCB.SelectedValue = VarauksetDG.CurrentRow.Cells[3].Value.ToString();
            SisaanDTP.Value = DateTime.Parse(VarauksetDG.CurrentRow.Cells[4].Value.ToString());
            UlosDTP.Value = DateTime.Parse(VarauksetDG.CurrentRow.Cells[5].Value.ToString());
        }

        //lisätään varaus "lisää" napin painalluksesta
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String tyontekija = TyontekijaCB.SelectedValue.ToString();
            String huonetyyppi = HuonetyyppiCB.SelectedValue.ToString();
            int huonenro = Int32.Parse(HuonenroCB.Text);
            DateTime sisaantemp = SisaanDTP.Value;
            DateTime ulostemp = UlosDTP.Value;

            String sisaan = sisaantemp.ToString("yyyy-MM-dd");
            String ulos = ulostemp.ToString("yyyy-MM-dd");

            if (tyontekija.Trim().Equals("") ||
                huonetyyppi.Trim().Equals("") ||
                huonenro.Equals("") ||
                sisaan.Trim().Equals("") ||
                ulos.Trim().Equals(""))
            {
                MessageBox.Show("Täytä kaikki kentät", "Virhe syötössä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean LisaaVaraus = varaukset.LisaaVaraus(tyontekija, huonetyyppi, huonenro, sisaan, ulos);
                if (LisaaVaraus)
                {
                    MessageBox.Show("Uusi varaus lisätty!", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta varausta ei pystytty lisäämään.", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            VarauksetDG.DataSource = varaukset.HaeVaraukset();
        }

        //muokkaa napin painalluksesta varauksen muokkaus
        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            String tyontekija = TyontekijaCB.SelectedValue.ToString();
            String huonetyyppi = HuonetyyppiCB.SelectedValue.ToString();
            int huonenro = Int32.Parse(HuonenroCB.Text);
            String sisaan = SisaanDTP.Value.ToString();
            String ulos = UlosDTP.Value.ToString();
            int varausnumero = Convert.ToInt32(VarausnroTB.Text);

            if (tyontekija.Trim().Equals("") ||
                huonetyyppi.Trim().Equals("") ||
                huonenro.Equals("") ||
                sisaan.Trim().Equals("") ||
                ulos.Trim().Equals(""))
            {
                MessageBox.Show("Täytä kaikki kentät", "Virhe syötössä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean MuokkaaVaraus = varaukset.MuokkaaVaraus(varausnumero, tyontekija, huonetyyppi, huonenro, sisaan, ulos);
                if (MuokkaaVaraus)
                {
                    MessageBox.Show("Varausta muokattu", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty muokkaamaan", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            VarauksetDG.DataSource = varaukset.HaeVaraukset();
        }

        //tyhjennetään "tyhjennä" napilla syöttökentät
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            VarausnroTB.Text = "";
            TyontekijaCB.SelectedIndex = 0;
            HuonetyyppiCB.SelectedIndex = 0;
            HuonenroCB.SelectedIndex = 0;
        }

        //poista napilla poistetaan varaus varausnumeron perusteella
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            int varausnumero = Convert.ToInt32(VarausnroTB.Text);


            if (varaukset.PoistaVaraus(varausnumero))
            {
                MessageBox.Show("Varaus poistettiin onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varauksen poisto epäonnistui", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaukset.HaeVaraukset();
        }

        private void HuonenroCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String huonenumero = Convert.ToString(HuonenroCB.SelectedValue);
                      
            
            String temp = huonenumero.Substring(0, 1);

            if (temp == "1")
            {
                HuonetyyppiCB.SelectedValue = "yhden hengen";
            }
            else if (temp == "2")
            {
                HuonetyyppiCB.SelectedValue = "kahden hengen";
            }
            else if (temp == "3")
            {
                HuonetyyppiCB.SelectedValue = "kolmen hengen";
            }
            else
            {
                HuonetyyppiCB.SelectedValue = "sviitti";
            }
            
        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String huonetyyppi = Convert.ToString(HuonetyyppiCB.SelectedValue);

            if (huonetyyppi == "yhden hengen")
            {
                HuonenroCB.DataSource = huoneet.HaeYhdenHengenHuoneet();
                HuonenroCB.DisplayMember = "huonenro";
                HuonenroCB.ValueMember = "huonenro";
            }
            if (huonetyyppi == "kahden hengen")
            {
                HuonenroCB.DataSource = huoneet.HaeKahdenHengenHuoneet();
                HuonenroCB.DisplayMember = "huonenro";
                HuonenroCB.ValueMember = "huonenro";
            }
            if (huonetyyppi == "kolmen hengen")
            {
                HuonenroCB.DataSource = huoneet.HaeKolmenHengenHuoneet();
                HuonenroCB.DisplayMember = "huonenro";
                HuonenroCB.ValueMember = "huonenro";
            }
            if (huonetyyppi == "sviitti")
            {
                HuonenroCB.DataSource = huoneet.HaeSviittiHuoneet();
                HuonenroCB.DisplayMember = "huonenro";
                HuonenroCB.ValueMember = "huonenro";
            }

        }
    }
}
