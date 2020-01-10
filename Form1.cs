using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Pocetni : Form
    {
        public Pocetni()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPristupi_Click(object sender, EventArgs e)
        {


            if (txtLozinka.Text.Equals("admin") && txtId.Text.Equals("admin"))
            {
                lblInfo.Text = txtId.Text;
                AdminView a = new AdminView();
                a.Show();
                this.Hide();
            }
            else if (txtLozinka.Text.Equals("") || txtLozinka.TextLength < 2 || txtLozinka.Text == null || txtId.Text == null || txtId.Text.Equals(""))
            {
                lblInfo.Text = "Neuspesno logovanje, probajte ponovo";
            }
            else
            {
                try
                {
                    string cs = @"server=localhost;userid=root;password=;database=frizerski";
                    var con = new MySqlConnection(cs);
                    con.Open();

                    var stmt = "select * from radnici where id='" + txtId.Text + "' AND lozinka='" + txtLozinka.Text + "';";
                    var exec = new MySqlCommand(stmt, con);
                    MySqlDataReader reader = exec.ExecuteReader();

                    RadnikView r = new RadnikView();
                    r.Show();


                }
                catch (Exception ez)
                {
                    lblInfo.Text = ez.Message;
                }

            }

        }



        private void btnZakazi_Click(object sender, EventArgs e)
        {
            //  lblInfo.Text = "Uspesno ste zakazali";
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pocetni_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=frizerski";
                var con = new MySqlConnection(cs);
                con.Open();

                var stmt = "select * from delatnosti;";
                var exec = new MySqlCommand(stmt, con);
                MySqlDataReader reader = exec.ExecuteReader();

                List<Delatnost> delatnosti = new List<Delatnost>();


                while (reader.Read()) {
                    delatnosti.Add(new Delatnost(reader.GetInt32("id"), reader.GetString("naziv"), reader.GetDouble("cena")));
                }

                foreach (Delatnost d in delatnosti) { 
                cmbDelatnosti.Items.Add(d.ToString());
                }

            }
            catch (Exception ez)
            {
                lblInfo.Text = ez.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
