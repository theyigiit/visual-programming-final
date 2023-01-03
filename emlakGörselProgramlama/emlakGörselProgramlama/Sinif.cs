using System;
using System.Data;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace emlakGörselProgramlama
{
    public class Sinif
    {
        public static MySqlConnection baglan = new MySqlConnection("server=localhost;uid=root;pwd='Emreygt41';database=emlak");
        public MySqlCommand komut;
        public int yardimciDegisken;
        public Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        public byte gezici;
        public DataTable dataTableDoldur(string tablo)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from " + tablo, Sinif.baglan);
            da.Fill(dt);
            return dt;
        }

    }
}
