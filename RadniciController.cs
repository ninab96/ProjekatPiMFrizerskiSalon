using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RadniciController
    {


        public static List<Radnik> getSveRadnici()
        {
            List<Radnik> radnici = new List<Radnik>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from radnici;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                while (reader.Read())
                {
                    radnici.Add(
                        new Radnik(reader.GetInt32("id"), 
                                   reader.GetString("ime_prezime"), 
                                   reader.GetString("broj_telefona"), 
                                   reader.GetString("jmbg"),
                                   reader.GetInt32("delatnost_id")
                               ));
                }

                return radnici;

            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return radnici;
        }
        public Boolean dodajRadnika(String imePrezime, String jmbg, String brojTelefona, String lozinka, String nazivDelatnosti)
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "INSERT INTO `radnici` (`id`, `ime_prezime`, `broj_telefona`, `jmbg`, `delatnost_id`, `lozinka`) VALUES (NULL,  '" + imePrezime + "', '" + jmbg + "', '" + brojTelefona + "',1, '" + lozinka + "');";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                return true;

            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
                return false;

            }
        }

        public static Boolean izbrisiRadnika(int id)
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();
                var stmt = "DELETE FROM radnici WHERE id = '" + id + "';";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();
                return true;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
                return false;

            }
        }


    }
}

