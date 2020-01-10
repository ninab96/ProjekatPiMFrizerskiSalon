using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Delatnost
    {
        public Delatnost(int id, string naziv, double cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
        }
        public int id { get; set; }
        public String naziv { get; set; }
        public double cena { get; set; }

        override
        public String ToString() {
            return this.naziv;
        }
    }
}
