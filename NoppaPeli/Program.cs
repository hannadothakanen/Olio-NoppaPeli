using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NoppaPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sovellus.Aja();
            }
            catch (Exception virhe)
            {
                WriteLine("Ohjelman suoritus pättyi virheeseen.");
                WriteLine($"VIRHE: {virhe.Message}");
            }
            finally
            {
                Write("Paina Enter lopettaaksesi...");
                ReadLine();
            }
        }
    }
}
