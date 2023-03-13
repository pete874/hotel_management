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
        // Luodaas asiakkaat instanssi ASIAKAS-classista
        ASIAKAS asiakkaat = new ASIAKAS();
        public Asiakkaat_form()
        {
            InitializeComponent();
        }

        //Tänne asetetaan asiat jotka halutaan tapahtuvan heti formin latautuessa
        private void Asiakkaat_Load(object sender, EventArgs e)
        {

            // Haetaan C# datagridiin kaikkien asiakkaiden tiedot tietokannasta käyttäen HaeAsiakkaat funktiota
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        // Funktio automaattiseen salasanan luontiin
        public String salasana()
        {
            //Käytettävät merkit josta salasana luodaan
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
                             'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 
                             'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 
                             'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 
                             'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 
                             'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //Luodulle salasanalla tehdään valmiiksi tyhjä string, johon luoto salasana syötetään
            String salis = "";

            //tehdään uusi random class instanssi, joka palauttaa satunnaisen numeron
            Random random = new Random();

            //for loopilla 10 merkkiä pitkä salasana
            for(int i = 0; i < 10; i++) 
            {
                //randomInt muuttujaan tallennetaan Nextillä satunnainen numero 0-61 väliltä
                int randomInt = random.Next(0, 61);
                //lisätään salis muuttujaan chars taulukosta satunnaisella indeksillä merkki
                salis += chars[randomInt];
            }
            //palautetaan salis stringi
            return salis;
        }

        // Lisää buttonin klikkaukseen funktio, joka tallentaa uuden asiakkaan tietokantaan
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            //Tallennetaan input kenttien sisällöt muuttujiin
            String etunimi = EtunimiTB.Text;
            String sukunimi = SukunimiTB.Text;
            String lahiosoite = LahiosoiteTB.Text;
            String postinumero = PostinumeroTB.Text;
            String ptoimipaikka = PToimipaikkaTB.Text;
            String kayttajanimi = etunimi.Substring(0, 3).ToLower() + sukunimi.Substring(0, 5).ToLower();
            String salsana = salasana();

            try
            {
                //Tarkistetaan ettei ole tyhjiä kenttiä
                if (etunimi.Trim().Equals("") ||
                    sukunimi.Trim().Equals("") ||
                    lahiosoite.Trim().Equals("") ||
                    postinumero.Trim().Equals("") ||
                    ptoimipaikka.Trim().Equals("") ||
                    kayttajanimi.Trim().Equals("") ||
                    salsana.Trim().Equals(""))
                {
                    MessageBox.Show("Täytä kaikki kentät", "Virhe syötössä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Itse asiakkaan lisäys jos kaikki kentät on täytetty
                else
                {
                    //lisätään asiakat jos lisaaAsiakas funktio palauttaa booleanin true, muuten annetaan virhe.
                    Boolean lisaaAsiakas = asiakkaat.LisaaAsiakas(etunimi, sukunimi, lahiosoite, postinumero, ptoimipaikka, kayttajanimi, salsana);
                    if (lisaaAsiakas)
                    {
                        MessageBox.Show("Uusi asiakas lisätty!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uutta asiakasta ei pystytty lisäämään.", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Käyttäjätunnus on jo olemassa!" + ex.Message);
            }

            //päivitetään datagridin tiedot
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        //Funktio asiakkaan muokkaamista varten muokkaa nappia klikattaessa
        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            //Tallennetaan input kenttien sisällöt muuttujiin
            String etunimi = EtunimiTB.Text;
            String sukunimi = SukunimiTB.Text;
            String lahiosoite = LahiosoiteTB.Text;
            String postinumero = PostinumeroTB.Text;
            String ptoimipaikka = PToimipaikkaTB.Text;
            String kayttajatunnus = KayttajatunnusTB.Text;

            //Tarkistetaan ettei ole tyhjiä kenttiä
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
                //lisätään asiakat jos lisaaAsiakas funktio palauttaa booleanin true, muuten annetaan virhe.
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
            //päivitetään datagridin tiedot
            AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
        }

        // Funktio asiakkaan poistamiseen poista nappia klikattaessa
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            //Tallennetaan käyttäjätunnuskentän sisältö muuttujaan
            String kayttajatunnus = KayttajatunnusTB.Text;

            //poistetaan käyttäjätunnuksen perusteella asiakas, jos käyttäjätunnus löytyy tietokannasta. Muussa tapauksessa ilmoitetaan virheestä
            if (asiakkaat.PoistaAsiakas(kayttajatunnus))
            {
                AsiakkaatDG.DataSource = asiakkaat.HaeAsiakkaat();
                MessageBox.Show("Asiakas poistettu!", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakkaan poistaminen epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //input kenttien tyhjennys asiakkaan lisäämisen päätteeksi
            TyhjennaBT.PerformClick();
        }

        //Tyhjennetään tekstikentät napin painalluksesta
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

        //Täytetään textikentät vastaamaan taulukosta painetun rivin tietoja
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
