using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            initDelatnosti();
            initRadnici();
            foreach (Aktivnost a in AktivnostController.getSveAktivnostiNeUradjene())
            {
                listBox5.Items.Add(a.id + "\t" + a.brojTelefona + "\t" + a.id_delatnost);
            }

            foreach (Aktivnost a in AktivnostController.getSveAktivnostiUradjene())
            {
                listBox6.Items.Add(a.id + "\t" + a.brojTelefona + "\t" + a.id_delatnost);
            }
            foreach (Klijent a in KlijentController.getSviKlijenti())
            {
                listBox3.Items.Add(a.id + "\t" + a.broj + "\t" + a.imePrezime);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelatnostiController dc = new DelatnostiController();
            if (dc.dodajDelatnost(inpNazivDelatnosti.Text, Double.Parse(inpCenaDelatnosti.Text)))
            {
                lblInfo.Text = "Uspesno dodata delatnost";
                initDelatnosti();
            }
            else {
                lblInfo.Text = "Neuspesno dodata delatnost";

            }
        }


        public void initDelatnosti() {
            comboBox2.Items.Clear();
            listBox2.Items.Clear();
            foreach (Delatnost d in DelatnostiController.getSveDelatnostiZaComboBox())
            {
                comboBox2.Items.Add(d.ToString());
                listBox2.Items.Add(d.id + "\t" +  d.naziv  + "\t" + d.cena );
            }
        }

        public void initRadnici()
        {
            listBox1.Items.Clear();
            foreach (Radnik d in RadniciController.getSveRadnici())
            {
                listBox1.Items.Add(d.id + "\t" + d.imePrezime + "\t" + d.jmbg);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DelatnostiController.izbrisiDelatnost(int.Parse(inpDelatnostID.Text)))
            {
                lblInfo.Text = "Uspesno izbrisana delatnost";
                initDelatnosti();
            }
            else
            {
                lblInfo.Text = "Neuspesno izbrisana delatnost";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RadniciController r = new RadniciController();
          
            if (r.dodajRadnika(inpIme.Text, inpJmbg.Text, inpBrojTelefona.Text, inpLozinka.Text, inpNazivDelatnosti.Text))
            {
                lblInfo.Text = "Uspesno dodat radnik";
                initRadnici();
            }
            else
            {
                lblInfo.Text = "Neuspesno dodat radnik";

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RadniciController.izbrisiRadnika(int.Parse(inpIdRadnik.Text)))
            {
                lblInfo.Text = "Uspesno izbrisan radnik";
                initRadnici();
            }
            else
            {
                lblInfo.Text = "Neuspesno izbrisan radnik";
            }

        }
    }
}
