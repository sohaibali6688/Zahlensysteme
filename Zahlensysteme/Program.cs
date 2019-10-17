using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            string nochmal;
            do
            {


                Console.WriteLine("Zahlensysteme in verschiedene Systeme umwandeln.");
                Console.WriteLine("1: Dezimal zu Binär");
                Console.WriteLine("2: Binär zu Dezimal");
                Console.WriteLine("3: Dezimal zu Hexadezimal");
                Console.WriteLine("4: Hexadezimal zu Dezimal");

                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Dezimalzahl eingeben");
                    int dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in binär: " + Von10zu2(dez));

                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Binärzahl eingeben");
                    string bin = Console.ReadLine();
                    Console.WriteLine(bin + " in dezimal: " + Von2zu10(bin));
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Dezimalzahl eingeben");
                    int dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in hexadezimal: " + Von10zu16(dez));
                }
                else if (auswahl == 4)
                {
                    Console.WriteLine("Hexadezimal eingeben");
                    string hexa = Console.ReadLine();
                    Console.WriteLine(hexa + " in dezimal: " + Von16zu10(hexa));
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte 1 oder 2 wählen");
                }
                Console.WriteLine("Neue Zahl um rechnen? (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");

        }

        static string Von10zu2(int dez)  //(int dez) ist Angabe 
        {
            string bin = "";
            int Q, R, Z;
            Z = dez;
            Q = 1;

            while (Q != 0)
            {
                Q = Z / 2;
                R = Z % 2;
                bin += Convert.ToString(R);
                // (bin += ) == (bin = bin + ...)
                Z = Q;
            }

            return Umkehren(bin);
        }

        static string Umkehren(String x)
        {
            string x_u = "";

            for (int i = x.Length - 1; i >= 0; i--)
            {
               x_u += x[i];
            }
            return x_u;
        }

        static double Von2zu10(string bin)
        {

            double Z = 0, S, E;
            for (int i = 0; i < bin.Length; i++)
            {
                S = Convert.ToDouble(Convert.ToString(bin[i]));
                E = Convert.ToDouble(bin.Length - 1 - i);
                Z += S * Math.Pow(2, E);
            }
            return Z;
        }


        static string Von10zu16(int dez)
        {
            string hexa = "";
            int Q, R, Z;
            Z = dez;
            Q = 1;

            while (Q != 0)
            {
                Q = Z / 16;
                R = Z % 16;
                hexa += ZahlZuBuchstabe(R);
                // (bin += ) == (bin = bin + ...)
                Z = Q;
            }

            return Umkehren(hexa);
        }
        static string ZahlZuBuchstabe(int zahl)
        {
            if (zahl == 10) return "A";
            else if (zahl == 11) return "B";
            else if (zahl == 12) return "C";
            else if (zahl == 13) return "D";
            else if (zahl == 14) return "E";
            else if (zahl == 15) return "F";
            else return Convert.ToString(zahl);

        }
        static int BuchstabeZuZahl(string Buchstabe)
        {
            if (Buchstabe == "A") return 10;
            else if (Buchstabe == "B") return 11;
            else if (Buchstabe == "C") return 12;
            else if (Buchstabe == "D") return 13;
            else if (Buchstabe == "E") return 14;
            else if (Buchstabe == "F") return 15;
            else return Convert.ToInt32 (Buchstabe)  ;

        }
        static double Von16zu10(string bin)
        {

            double Z = 0, S, E;
            for (int i = 0; i < bin.Length; i++)
            {
                S =BuchstabeZuZahl(Convert.ToString(bin[i]));
                E = Convert.ToDouble(bin.Length - 1 - i);
                Z += S * Math.Pow(16, E);

            }
            return Z;
        }




    }
}
