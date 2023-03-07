using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class ASIAKAS
    {
        YHDISTA yhteys = new YHDISTA();

        public DataTable HaeAsiakkaat()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, kayttajanimi FROM asiakkaat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        public bool LisaaAsiakas(String etunimi, String sukunimi, String lahiosoite, String postinumero, String postitoimipaikka, String kayttajanimi, String salasana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaysKysely = "INSERT INTO asiakkaat " + "(etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, kayttajanimi, salasana) " +
                "VALUES (@enm, @snm, @los, @pnm, @ptp, @ktu, @sal); ";
            komento.CommandText = lisaysKysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = etunimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sukunimi;
            komento.Parameters.Add("@los", MySqlDbType.VarChar).Value = lahiosoite;
            komento.Parameters.Add("@pnm", MySqlDbType.VarChar).Value = postinumero;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = postitoimipaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajanimi;
            komento.Parameters.Add("@sal", MySqlDbType.VarChar).Value = salasana;

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

        public bool MuokkaaAsiakas(String etunimi, String sukunimi, String lahiosoite, String postinumero, String postitoimipaikka, String kayttajatunnus)
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

        public bool PoistaAsiakas(String kayttajatunnus)
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
