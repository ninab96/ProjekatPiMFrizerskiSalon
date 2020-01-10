using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Radnik
    {
        public Radnik(int id, string imePrezime, string brojTelefona, string jmbg, int delatnostId)
        {
            this.id = id;
            this.imePrezime = imePrezime;
            this.brojTelefona = brojTelefona;
            this.jmbg = jmbg;
            this.delatnostId = delatnostId;
        }

        public int id { get; set; }
        public String imePrezime { get; set; }
        public String brojTelefona { get; set; }
        public String jmbg { get; set; }
        public int delatnostId { get; set; }
    }
}
