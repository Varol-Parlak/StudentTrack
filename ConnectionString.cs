using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace denemeGrafik
{
    public class ConnectionString
    {

        public MySqlConnection Baglan()
        {
            MySqlConnection baglanti = new MySqlConnection("Server = 127.0.0.1; Database=library;Uid=root;Pwd=Yusef1385!?;");
            baglanti.Open();
            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
