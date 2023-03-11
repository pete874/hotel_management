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
        VARAUS varaukset = new VARAUS();
        HUONE huoneet = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        public Varaukset_form()
        {
            InitializeComponent();
        }

        private void Varaukset_form_Load(object sender, EventArgs e)
        {
            SisaanDTP.CustomFormat = "dd.MM.yyyy";
            SisaanDTP.Format = DateTimePickerFormat.Custom;

            UlosDTP.CustomFormat = "dd.MM.yyyy";
            UlosDTP.Format = DateTimePickerFormat.Custom;

            VarauksetDG.DataSource = varaukset.HaeVaraukset();

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

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausnroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            TyontekijaCB.SelectedValue = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            HuonetyyppiCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            HuonenroCB.SelectedValue = VarauksetDG.CurrentRow.Cells[3].Value.ToString();
            SisaanDTP.Value = DateTime.Parse(VarauksetDG.CurrentRow.Cells[4].Value.ToString());
            UlosDTP.Value = DateTime.Parse(VarauksetDG.CurrentRow.Cells[5].Value.ToString());
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String tyontekija = TyontekijaCB.SelectedValue.ToString();
            String huonetyyppi = HuonetyyppiCB.SelectedValue.ToString();
            int huonenro = Int32.Parse(HuonenroCB.Text);
            String sisaan = SisaanDTP.Value.ToString();
            String ulos = UlosDTP.Value.ToString();

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

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            VarausnroTB.Text = "";
            TyontekijaCB.SelectedIndex = 0;
            HuonetyyppiCB.SelectedIndex = 0;
            HuonenroCB.SelectedIndex = 0;
        }

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
    }
}
