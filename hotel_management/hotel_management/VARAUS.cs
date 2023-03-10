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
        YHDISTA yhteys = new YHDISTA();

        public DataTable HaeVaraukset()
        {
            MySqlCommand haeKaikki = new MySqlCommand("SELECT varausnumero, tyontekija, huonetyyppi, huonenro, sisaan, ulos FROM varaukset", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            return taulu;
        }

        public bool LisaaVaraus(String tyontekija, String huonetyyppi, int huonenro, String sisaan, String ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaysKysely = "INSERT INTO varaukset (tyontekija, huonetyyppi, huonenro, sisaan, ulos) VALUES (@tyo, @hty, @hnu, @sis, @ulo); ";
            komento.CommandText = lisaysKysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@tyo", MySqlDbType.VarChar).Value = tyontekija;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = huonetyyppi;
            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;
            komento.Parameters.Add("@sis", MySqlDbType.VarChar).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;


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

        public bool MuokkaaVaraus(int varausnumero, String tyontekija, String huonetyyppi, int huonenro, String sisaan, String ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaysKysely = "UPDATE `varaukset` SET `tyontekija` = @tyo,`huonetyyppi` = @hty, `huonenro` = @hnu, `sisaan` = @sis, `ulos` = @ulo WHERE varausnumero = @vnu";
            komento.CommandText = lisaysKysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@vnu", MySqlDbType.Int32).Value = varausnumero;
            komento.Parameters.Add("@tyo", MySqlDbType.VarChar).Value = tyontekija;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = huonetyyppi;
            komento.Parameters.Add("@hnu", MySqlDbType.Int32).Value = huonenro;
            komento.Parameters.Add("@sis", MySqlDbType.VarChar).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;


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

        public bool PoistaVaraus(int varausnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaysKysely = "DELETE FROM varaukset WHERE varausnumero = @vnu";
            komento.CommandText = lisaysKysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@vnu", MySqlDbType.Int32).Value = varausnumero;


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
