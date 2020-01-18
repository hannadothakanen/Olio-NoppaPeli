using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Helpers;
using static Helpers.Syote;

namespace NoppaPeli
{
    static class Sovellus
    {
        static int VOITONPISTERAJA = 3;
        static string voittaja = "";


        public static int Aja()
        {
            try
            {
                WriteLine("Noppa-peli");

                Pelaaja p1, p2; //Luodaan kaksi pelaaja-oliota ja pyydetään käyttäjältä nimet
                p1 = new Pelaaja(Merkkijono("Anna pelaajan 1 nimi: "));
                p2 = new Pelaaja(Merkkijono("Anna pelaajan 2 nimi: "));

                Noppa n1, n2, n3, n4; //Luodaan neljä noppa-oliota, kaksi kummallekkin pelaajalle
                n1 = new Noppa(Noppa.Lukema);
                n2 = new Noppa(Noppa.Lukema);
                n3 = new Noppa(Noppa.Lukema);
                n4 = new Noppa(Noppa.Lukema);

                do
                {
                    Noppa.HeittoLkm++; //kasvattaa heittojen lukumäärää yhdellä joka kierroksella
                    WriteLine($"Heittokierros: {Noppa.HeittoLkm}");
                    int tulos1 = Noppa.Heita(n1);  //heittää nopat
                    int tulos2 = Noppa.Heita(n2);
                    int tulos3 = Noppa.Heita(n3);
                    int tulos4 = Noppa.Heita(n4);
                    WriteLine($"{p1.Nimi}:  {tulos1} +  {tulos2} = {tulos1 + tulos2}"); //tulostaa kierroksen tulokset
                    WriteLine($"{p2.Nimi}:  {tulos3} +  {tulos4} = {tulos3 + tulos4}");

                    if (tulos1 + tulos2 > tulos3 + tulos4) //jos pelaaja 1 voittaa kierroksen, kasvattaa hänen pisteitä yhdellä ja nollaa toisen pelaajan pisteet
                    {
                        p1.Pisteet++;
                        p2.Pisteet = 0;
                    }
                    else if (tulos1 + tulos2 < tulos3 + tulos4) //jos pelaaja 2 voittaa kierroksen, kasvattaa hänen pisteitä yhdellä ja nollaa toisen pelaajan pisteet
                    {
                        p2.Pisteet++;
                        p1.Pisteet = 0;
                    }
                    if (p1.Pisteet == VOITONPISTERAJA || p2.Pisteet == VOITONPISTERAJA) //pysäyttää ohjelman kun pisteraja täyttyy ja määrittelee voittajan
                    {
                        if (p1.Pisteet == VOITONPISTERAJA)
                        {
                            voittaja = p1.Nimi;
                        }
                        else if (p2.Pisteet == VOITONPISTERAJA)
                        {
                            voittaja = p2.Nimi;
                        }
                        WriteLine();
                        WriteLine($"Pelin voittaja on {voittaja} ja noppia heitettiin {Noppa.HeittoLkm} kertaa!");
                        break;
                    }
                    else //jos mikään kolmesta kohdasta ei täyty (esim. jos pelaajat saavat saman tuloksen), suorittaa ohjelman uudelleen
                    {
                        continue;
                    }
                }
                while (p1.Pisteet != VOITONPISTERAJA || p2.Pisteet != VOITONPISTERAJA); //tähän kohtaan ei ole tarkoitus mennä, se on vain varmistus
                return 0;
                
            }
            finally
            {
                ReadLine();
            }
        }
    }
}
