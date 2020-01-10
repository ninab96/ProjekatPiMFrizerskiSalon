using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Klijent
    {
        public Klijent(int id, string broj, string imePrezime)
        {
            this.id = id;
            this.broj = broj;
            this.imePrezime = imePrezime;
        }

        public int id { get; set; }
        public String broj { get; set; }
        public String imePrezime {get;set;}
    
    }
}
