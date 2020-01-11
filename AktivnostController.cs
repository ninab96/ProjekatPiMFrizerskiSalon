using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AktivnostController
    {

        public static List<Aktivnost> getSveAktivnosti()
        {
            List<Aktivnost> aktivnosti = new List<Aktivnost>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from aktivnosti;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                while (reader.Read())
                {
                    aktivnosti.Add(
                        new Aktivnost(
                                   reader.GetInt32("id"),
                                   reader.GetString("broj_telefona"),
                                   reader.GetInt32("delatnost_id"),
                                   reader.GetString("dan"),
                                   reader.GetString("sat"),
                                   reader.GetString("godina"),
                                   reader.GetString("mesec"),
                                   reader.GetInt32("status")
                               ));
                }
                return aktivnosti;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return aktivnosti;
        }


        public static List<Aktivnost> getSveAktivnostiNeUradjene()
        {
            List<Aktivnost> aktivnosti = new List<Aktivnost>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from aktivnosti where status=0;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                while (reader.Read())
                {
                    aktivnosti.Add(
                        new Aktivnost(
                                   reader.GetInt32("id"),
                                   reader.GetString("broj_telefona"),
                                   reader.GetInt32("delatnost_id"),
                                   reader.GetString("dan"),
                                   reader.GetString("sat"),
                                   reader.GetString("godina"),
                                   reader.GetString("mesec"),
                                   reader.GetInt32("status")
                               ));
                }
                return aktivnosti;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return aktivnosti;
        }
        public static List<Aktivnost> getSveAktivnostiUradjene()
        {
            List<Aktivnost> aktivnosti = new List<Aktivnost>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from aktivnosti where status=1;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                while (reader.Read())
                {
                    aktivnosti.Add(
                        new Aktivnost(
                                   reader.GetInt32("id"),
                                   reader.GetString("broj_telefona"),
                                   reader.GetInt32("delatnost_id"),
                                   reader.GetString("dan"),
                                   reader.GetString("sat"),
                                   reader.GetString("godina"),
                                   reader.GetString("mesec"),
                                   reader.GetInt32("status")
                               ));
                }
                return aktivnosti;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return aktivnosti;
        }

        public Boolean zakazi(int delatnost_id, String dan, String sat, String mesec, String imePrezime, String brojTelefona) {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "SELECT COUNT(id) FROM `aktivnosti` WHERE status=0 AND " +
                    "`sat` = " + sat + " AND `mesec` = " + mesec + " AND" +
                    " `dan` = " + dan +" AND "+"`delatnost_id` = "+delatnost_id+";";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                int res = 0;
                while (reader.Read())
                {
                    res += int.Parse(reader.GetString(0));
                }
                reader.Close();
                if (res > 0)
                {
                    return false;
                }
                else {
                  var stmt2 = "INSERT INTO `aktivnosti` (`id`, `broj_telefona`, `delatnost_id`, `dan`, `sat`, `status`, `mesec`) " +
                              "VALUES(NULL,"+brojTelefona+","+delatnost_id+","+dan+","+sat+",'0',"+mesec+")";
                   var exec2 = new MySqlCommand(stmt2, con);
                    exec2.ExecuteNonQuery();
                    return true;                
                }
            }
            catch (Exception ez)
            {
                System.Diagnostics.Debug.WriteLine(ez.Message);
                return false;
            }
         
        }
    }
}
