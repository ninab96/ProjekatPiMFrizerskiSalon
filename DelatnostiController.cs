using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DelatnostiController
    {

        public Boolean dodajDelatnost(String naziv, Double cena) {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "INSERT INTO `delatnosti` (`id`, `naziv`, `cena`) VALUES (NULL, '"+naziv+"', '"+cena+"');";
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

        public static Boolean izbrisiDelatnost(int id)
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "DELETE FROM delatnosti WHERE id = '"+id+"';";
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


        public static List<Delatnost> getSveDelatnostiZaComboBox() {
            List<Delatnost> delatnosti = new List<Delatnost>();
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from delatnosti;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();



                while (reader.Read())
                {
                    delatnosti.Add(new Delatnost(reader.GetInt32("id"), reader.GetString("naziv"), reader.GetDouble("cena")));
                }

                return delatnosti;

            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
            return delatnosti;
        }

    }
}
