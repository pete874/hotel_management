using MySql.Data.MySqlClient;
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
        YHDISTA kirjaudu = new YHDISTA();
        public KirjauduForm()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            
            //komento muuttujaan tallennetaan uusi SQL komento, jossa verrataan käyttäjänimeä ja salasanaa
            MySqlCommand komento = new MySqlCommand("SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @ktu AND salasana = @sal" );

            // Luodaan muuttujat, joita voimme käyttää SQL komennon sisällä vertaukseen.
            // Muuttujan sisältävät käyttäjätunnus ja salasana textboxien textin
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = KayttajatunnusTB.Text;
            komento.Parameters.Add("@sal", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            komento.Connection = kirjaudu.otaYhteys();

           

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //luodaan uusi DataTable taulu muuttujaan
            DataTable taulu = new DataTable();

            //Valitaan adapteriin komento(ylempänä oleva SQL komento) joka halutaan ajaa
            adapter.SelectCommand = komento;

            //täytetään DataTable taulu riveillä, jotka haetaan määritetyllä SQL komennolla.
            //Jos vain toinen salasanasta ja kayttajatunnuksesta menee oikein, tulee rivejä tauluun 1.
            //Jos kummatkin menevät väärin, rivejä on 0.
            //jos kummatkin menevät oikein, rivejä on 2.
            adapter.Fill(taulu);

            kirjaudu.avaaYhteys();

            //tarkistetaan taulun rivit. Jotta käyttäjätunnus ja salasana menisivät oikein, pitää rivejä olla 2, joka tarkistetaan if lauseella.
            //huom, yksi rivi on nollas indeksi, joten tarkistetaan onko count isompi kuin 0.
            if (taulu.Rows.Count > 0)
            {
                kirjaudu.suljeYhteys();
                PaasivuForm paasivu = new PaasivuForm();
                paasivu.Show();
                this.Hide();
            }
            else
            {                
                MessageBox.Show("Väärä salasana tai käyttäjätunnus", "Virhe syötössä!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
