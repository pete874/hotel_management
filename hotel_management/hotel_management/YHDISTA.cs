using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class YHDISTA
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource = sql8.freesqldatabase.com; port = 3306; username = sql8603367; password = Vnq2M3BaYI; database = sql8603367");
    
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys() 
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }

    
}
