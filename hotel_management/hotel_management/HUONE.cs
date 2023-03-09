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
        YHDISTA yhteys = new YHDISTA();

        public DataTable HaeHuoneet()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT huonenro, huonetyyppi, puhelin, vapaa FROM huoneet", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        public DataTable HuoneTyyppiLista()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT kategoriaid, huonetyyppi FROM huonekategoriat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        public bool LisaaHuone(int huonenro, int huonetyyppi, string puhelin, String vapaa)
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

        public bool MuokkaaHuone(String etunimi, String sukunimi, String lahiosoite, String postinumero, String postitoimipaikka, String kayttajatunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String muokkauskysely = "UPDATE `asiakkaat` SET `etunimi` = @enm,`sukunimi` = @snm, `lahiosoite` = @los, `postinumero` = @pnm, `postitoimipaikka` = @ptp WHERE kayttajanimi = @ktu";
            komento.CommandText = muokkauskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = etunimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sukunimi;
            komento.Parameters.Add("@los", MySqlDbType.VarChar).Value = lahiosoite;
            komento.Parameters.Add("@pnm", MySqlDbType.VarChar).Value = postinumero;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = postitoimipaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajatunnus;

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

        public bool PoistaHuone(String kayttajatunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE kayttajanimi = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajatunnus;

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

