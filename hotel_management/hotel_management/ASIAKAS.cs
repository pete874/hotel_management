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
        //tehdään aikaisemmin tehdystä YHDISTA classista uusi instanssi "yhteys" muuttujaan, jotta voimme käyttää classin toimintoja helposti tämän classin sisällä.
        YHDISTA yhteys = new YHDISTA();

        //Funktiolla haetaan SQL:stä kaikki oleelliset tiedot asiakkaista ja tallennetaan ne MySqlAdapterin avulla C# DataTableksi, jonka nimeksi tulee "taulu". Ja lopuksi palautetaan taulu.
        public DataTable HaeAsiakkaat()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, kayttajanimi FROM asiakkaat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        //Funktiolla haetaan asiakkaiden tiedoista pelkästään etunimi ja sukunimi ja tallennetaan adapterin avulla C# tauluun ja palautetaan taulu.
        public DataTable AsiakasLista()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT etunimi, sukunimi FROM asiakkaat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);


            //lisätään taulu muuttujaan yksi columni lisää, joka yhdistää etunimen ja sukunimen. Näin saadaan varauksen formin comboboxiin etu- ja sukunimi näkyviin
            taulu.Columns.Add("FullName", typeof(string), "etunimi + ' ' + sukunimi");
            
            //Taulusta tulee ulos sarakkeet etunimi,sukunimi ja FullName
            return taulu;
        }

        //Funktio asiakkaan lisäämiseen tietokantaan
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

        //Funktio asiakkaan muokkaamiseen tietokannassa
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

        //Funktio asiakkaan poistamiseen tietokannasta
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
