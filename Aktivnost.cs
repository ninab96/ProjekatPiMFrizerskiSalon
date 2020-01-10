using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aktivnost
    {
        public Aktivnost(int id, string brojTelefona, int id_delatnost, string dan, string sat, string godina, string mesec, int status)
        {
            this.id = id;
            this.brojTelefona = brojTelefona;
            this.id_delatnost = id_delatnost;
            this.dan = dan;
            this.sat = sat;
            this.godina = godina;
            this.mesec = mesec;
            this.status = status;
        }

        public int id { get; set; }
        public String brojTelefona { get; set; }
        public int id_delatnost { get; set; }
        public String dan { get; set; }
        public String sat { get; set; }
        public String godina { get; set; }
        public String mesec { get; set; }
        public int status { get; set; }
    }
}
