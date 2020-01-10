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

            foreach (Aktivnost a in AktivnostController.getSveAktivnostiNeUradjene())
            {
                listBox1.Items.Add(a.id + "\t" + a.brojTelefona + "\t" + a.id_delatnost);
            }

        }


 
    }
}
