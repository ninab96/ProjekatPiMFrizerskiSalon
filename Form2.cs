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
    public partial class RadnikView : Form
    {
        public RadnikView()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initAktivnosti();
        }
        public void initAktivnosti() {
            foreach (Aktivnost a in AktivnostController.getSveAktivnostiNeUradjene())
            {
                listBox1.Items.Add(a.id + "\t" + a.brojTelefona + "\t");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


           // UPDATE `aktivnosti` SET `status` = '1' WHERE `aktivnosti`.`id` = 1;
            initAktivnosti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // UPDATE `aktivnosti` SET `status` = '1' WHERE `aktivnosti`.`id` = 1;
            initAktivnosti();

        }
    }
}
