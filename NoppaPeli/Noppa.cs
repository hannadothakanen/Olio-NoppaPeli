using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NoppaPeli
{
    class Noppa
    {
        public static int Lukema { get; set; }
        public static int HeittoLkm { get; set; }

        public static Random Random = new Random();

        public Noppa(int HeittoLkm)
        {
            HeittoLkm = 0;
        }
        public static int Heita(object Noppa) //metodi, joka arpoo nopalle tulokset
        {
            Lukema = Random.Next(1, 7);
            return Lukema;
        }
    }
}
