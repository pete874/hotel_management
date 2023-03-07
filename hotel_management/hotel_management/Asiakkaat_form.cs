using MySql.Data.MySqlClient;
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
    public partial class Asiakkaat_form : Form
    {   
        ASIAKAS asiakkaat = new ASIAKAS();
        public Asiakkaat_form()
        {
            InitializeComponent();
        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String etunimi = EtunimiTB.Text;
            String sukunimi = SukunimiTB.Text;
            String lahiosoite = LahiosoiteTB.Text;
            String postinumero = PostinumeroTB.Text;
            String ptoimipaikka = PToimipaikkaTB.Text;
            String kayttajanimi = KayttajatunnusTB.Text;
            String salasana = SalasanaTB.Text;

            if (etunimi.Trim().Equals("") || 
                sukunimi.Trim().Equals("") || 
                lahiosoite.Trim().Equals("") || 
                postinumero.Trim().Equals("") || 
                ptoimipaikka.Trim().Equals("") || 
                kayttajanimi.Trim().Equals("") || 
                salasana.Trim().Equals(""))
            {
                MessageBox.Show("Täytä kaikki kentät", "Virhe syötössä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakkaat.LisaaAsiakas(etunimi, sukunimi, lahiosoite, postinumero, ptoimipaikka, kayttajanimi, salasana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään.", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            String etunimi = EtunimiTB.Text;
            String sukunimi = SukunimiTB.Text;
            String lahiosoite = LahiosoiteTB.Text;
            String postinumero = PostinumeroTB.Text;
            String ptoimipaikka = PToimipaikkaTB.Text;
            String kayttajatunnus = KayttajatunnusTB.Text;
            

            if (etunimi.Trim().Equals("") ||
                 sukunimi.Trim().Equals("") ||
                 lahiosoite.Trim().Equals("") ||
                 postinumero.Trim().Equals("") ||
                 ptoimipaikka.Trim().Equals(""))
            {
                MessageBox.Show("Täytä vaaditut kentät", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakkaat.MuokkaaAsiakas(etunimi, sukunimi, lahiosoite, postinumero, ptoimipaikka, kayttajatunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Muokkaus suoritettu!", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Täytä vaaditut kentät", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String kayttajatunnus = KayttajatunnusTB.Text;
            if (asiakkaat.PoistaAsiakas(kayttajatunnus))
            {
                AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
                MessageBox.Show("Asiakas poistettu!", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakkaan poistaminen epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            LahiosoiteTB.Text = "";
            PostinumeroTB.Text = "";
            PToimipaikkaTB.Text = "";
            KayttajatunnusTB.Text = "";
            SalasanaTB.Text = "";
        }

        private void AsiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EtunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            SukunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            LahiosoiteTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            PostinumeroTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            PToimipaikkaTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            KayttajatunnusTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString(); 
        }
    }
}
