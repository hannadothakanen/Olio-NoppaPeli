using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NoppaPeli
{
    public class Pelaaja: INimi
    {
        public string Nimi { get; set; }
        public int Pisteet { get; set; }
        
        public Pelaaja(string nimi)
        {
            Nimi = nimi;
            Pisteet = 0;
        }
        
        public override string ToString()
        {
            return ($"Pisteet:{Pisteet} Nimi:{Nimi}");
        }
    }
}

