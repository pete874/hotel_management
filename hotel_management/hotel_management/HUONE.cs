using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class HUONE
    {
        //Luodaan yhteys instanssi YHDISTA classista.
        YHDISTA yhteys = new YHDISTA();

        //Funktiolla haetaan SQL:stä huoneiden tiedot tauluun ja palautetaan taulu
        public DataTable HaeHuoneet()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT huonenro, huonetyyppi, puhelin, vapaa FROM huoneet", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        //Funktiolla haetaan SQL huonekategoriasta kategoriaid ja huonetyyppi jotka tallennetaan tauluun ja palautetaan taulu
        public DataTable HuoneTyyppiLista()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT kategoriaid, huonetyyppi FROM huonekategoriat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        //Funktio huoneen SQL:ään lisäämistä varten
        public bool LisaaHuone(int huonenro, int huonetyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaysKysely = "INSERT INTO huoneet (huonenro, huonetyyppi, puhelin, vapaa) VALUES (@hnr, @hty, @puh, @vap); ";
            komento.CommandText = lisaysKysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = huonenro;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = huonetyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        //Funktio huoneen muokkaamiseen SQL:ssä
        public bool MuokkaaHuone(int huonenro, int huonetyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String muokkauskysely = "UPDATE `huoneet` SET `huonetyyppi` = @hty, `puhelin` = @puh, `vapaa` = @vap WHERE huonenro = @hnu";
            komento.CommandText = muokkauskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = huonetyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }

        }

        //Funktio huoneen poistamiseen SQL:stä
        public bool PoistaHuone(int huonenro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE huonenro = @hnu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}

