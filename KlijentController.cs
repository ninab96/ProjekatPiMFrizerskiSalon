using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KlijentController
    {
        public static List<Klijent> getSviKlijenti()
        {
            List<Klijent> klijenti = new List<Klijent>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from klijenti;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                while (reader.Read())
                {
                    klijenti.Add(
                        new Klijent(
                                   reader.GetInt32("id"),
                                   reader.GetString("broj"),
                                   reader.GetString("ime_prezime")
                               ));
                }
                return klijenti;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return klijenti;
        }
    }
}
