using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class VARAUS
    {
        //YHDISTA classista instanssi yhteys muuttujaan jota käytetään tämän classin sisällä
        YHDISTA yhteys = new YHDISTA();

        //Funktiolla haetaan tiedot varauksista, tallennetaan ne tauluun ja palautetaan taulu
        public DataTable HaeVaraukset()
        {
            // tehdään uusi mysqlcommand. Sulkeiden sisään tulee itse komento ja otaYhteys funktio. MySqlCommand(String, MySqlConnection)
            MySqlCommand haeKaikki = new MySqlCommand("SELECT varausnumero, tyontekija, huonetyyppi, huonenro, sisaan, ulos FROM varaukset", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        //Funktio varauksen lisäämistä varten
        public bool LisaaVaraus(String tyontekija, String huonetyyppi, int huonenro, String sisaan, String ulos)
        {
            //tehdään uusi MySqlCommand.
            MySqlCommand komento = new MySqlCommand();
            //Tallennetaan stringiin SQL kysely. Tämä voidaan myös laittaa suoraan MySqlCommandin sulkeiden sisään yhteys-funktion kanssa, niikuin ylimmässä funktiossa on tehty.
            String lisaysKysely = "INSERT INTO varaukset (tyontekija, huonetyyppi, huonenro, sisaan, ulos) VALUES (@tyo, @hty, @hnu, @sis, @ulo); ";


            //Asettaa Stringin SQL komennoksi komento muuttujaan
            komento.CommandText = lisaysKysely;

            //Asettaa otaYhteys funktion SQL yhteydeksi Connection komennolla.  Tämä voidaan myös laittaa yhteydeksi MySqlCommandin sisään pilkun jälkeen toiseksi parametriksi
            komento.Connection = yhteys.otaYhteys();


            //Tehdään C# puolelta luettavat muuttujat, joita voidaan käyttää SQL komennossa. Huom. Normaalit C# muuttujat eivät toimi SQL komennossa.
            komento.Parameters.Add("@tyo", MySqlDbType.VarChar).Value = tyontekija;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = huonetyyppi;
            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;
            komento.Parameters.Add("@sis", MySqlDbType.VarChar).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;


            yhteys.avaaYhteys();

            //ExecuteNonQuerya käytetään SQL komentoihin, joilla ei palauteta dataa vaan pelkästään tallennetaan dataa tietokantaan(UPDATE,INSERT,DELETE)
            //Jos SQL-lisäyskysely onnistuu esimerkiksi päivittämään rivin tietokannnassa, palauttaa ExecuteNonQuery int-tyyppinä vaikutuksen alaisena olevien rivien määrän
            // eli kuinka monta riviä esim päivitetty tai poistettu.
            // Tässä kyseisessä komennossa rivejä palautuu aina yksi, jos on onnistuttu muuttamaan dataa. Jos yhtäkään riviä ei muutettu, palautuu numero -1
            //Alhaalla tarkistetaan onko riviä onnistuttu muuttamaan ja palautetaan joko true tai false boolean.
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

        //Funktio varauksen muokkaamiseen
        public bool MuokkaaVaraus(int varausnumero, String tyontekija, String huonetyyppi, int huonenro, DateTime sisaan, DateTime ulos)
        {
            //tehdään uusi MySqlCommand.
            MySqlCommand komento = new MySqlCommand();

            //Tallennetaan stringiin SQL kysely. Tämä voidaan myös laittaa suoraan MySqlCommandin sulkeiden sisään yhteys-funktion kanssa, niinkuin ylimmässä funktiossa on tehty.
            String lisaysKysely = "UPDATE `varaukset` SET `tyontekija` = @tyo,`huonetyyppi` = @hty, `huonenro` = @hnu, `sisaan` = @sis, `ulos` = @ulo WHERE varausnumero = @vnu";

            //Asettaa Stringin SQL komennoksi komento muuttujaan
            komento.CommandText = lisaysKysely;

            //Asettaa otaYhteys funktion SQL yhteydeksi Connection komennolla. Tämä voidaan myös laittaa yhteydeksi MySqlCommandin sisään pilkun jälkeen toiseksi parametriksi
            komento.Connection = yhteys.otaYhteys();

            //Tehdään C# puolelta luettavat muuttujat, joita voidaan käyttää SQL komennossa. Huom. Normaalit C# muuttujat eivät toimi SQL komennossa.
            komento.Parameters.Add("@vnu", MySqlDbType.Int32).Value = varausnumero;
            komento.Parameters.Add("@tyo", MySqlDbType.VarChar).Value = tyontekija;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = huonetyyppi;
            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;


            yhteys.avaaYhteys();

            //ExecuteNonQuerya käytetään SQL komentoihin, joilla ei palauteta dataa vaan pelkästään tallennetaan dataa tietokantaan(UPDATE,INSERT,DELETE)
            //Jos SQL-lisäyskysely onnistuu esimerkiksi päivittämään rivin tietokannnassa, palauttaa ExecuteNonQuery int-tyyppinä vaikutuksen alaisena olevien rivien määrän
            // eli kuinka monta riviä esim päivitetty tai poistettu.
            // Tässä kyseisessä komennossa rivejä palautuu aina yksi, jos on onnistuttu muuttamaan dataa. Jos yhtäkään riviä ei muutettu, palautuu numero -1
            //Alhaalla tarkistetaan onko riviä onnistuttu muuttamaan ja palautetaan joko true tai false boolean.
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

        //Funktio varauksen poistamiseen
        public bool PoistaVaraus(int varausnumero)
        {

            //tehdään uusi MySqlCommand.
            MySqlCommand komento = new MySqlCommand();

            //Tallennetaan stringiin SQL komento. Tämä voidaan myös laittaa suoraan MySqlCommandin sulkeiden sisään yhteys-funktion kanssa, niinkuin ylimmässä funktiossa on tehty.
            String lisaysKysely = "DELETE FROM varaukset WHERE varausnumero = @vnu";

            //Asettaa Stringin SQL komennoksi komento muuttujaan
            komento.CommandText = lisaysKysely;

            //Asettaa otaYhteys funktion SQL yhteydeksi Connection komennolla. Tämä voidaan myös laittaa yhteydeksi MySqlCommandin sisään pilkun jälkeen toiseksi parametriksi
            komento.Connection = yhteys.otaYhteys();

            //Tehdään C# puolelta luettavat muuttujat, joita voidaan käyttää SQL komennossa. Huom. Normaalit C# muuttujat eivät toimi SQL komennossa.
            komento.Parameters.Add("@vnu", MySqlDbType.Int32).Value = varausnumero;


            yhteys.avaaYhteys();

            //ExecuteNonQuerya käytetään SQL komentoihin, joilla ei palauteta dataa vaan pelkästään tallennetaan dataa tietokantaan(UPDATE,INSERT,DELETE)
            //Jos SQL-lisäyskysely onnistuu esimerkiksi päivittämään rivin tietokannnassa, palauttaa ExecuteNonQuery int-tyyppinä vaikutuksen alaisena olevien rivien määrän
            // eli kuinka monta riviä esim päivitetty tai poistettu.
            // Tässä kyseisessä komennossa rivejä palautuu aina yksi, jos on onnistuttu muuttamaan dataa. Jos yhtäkään riviä ei muutettu, palautuu numero -1
            //Alhaalla tarkistetaan onko riviä onnistuttu muuttamaan ja palautetaan joko true tai false boolean.
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
