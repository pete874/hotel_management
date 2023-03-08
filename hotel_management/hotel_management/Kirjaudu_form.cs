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
            

            MySqlCommand komento = new MySqlCommand("SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @ktu AND salasana = @sal" );

            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = KayttajatunnusTB.Text;
            komento.Parameters.Add("@sal", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            komento.Connection = kirjaudu.otaYhteys();

           

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(taulu);
            kirjaudu.avaaYhteys();

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
