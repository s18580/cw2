using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // domyslne ustawienie zmiennych
            String plikwe = "data.csv",
                   plikwy = "zesult.xml",
                   format = "xml",
                   plikerror = "log.txt";

            if (args.Length<3) // sprwadzenie czy zostały podane wszystie argumenty
            {
                Regex plikweA, plikwyA, formatA;
                plikweA = new Regex(@".*\.csv");
                plikwyA = new Regex(@".*\.xml");
                formatA = new Regex(@"xml");

                for (int i=0;i<args.Length;i++)
                {
                    if (plikweA.IsMatch(args[i])) // jesli argument pasuje do regexa pliku wejsciowego to args[i] staje sie plikiem wejsciowym
                    {
                        plikwe = args[i];
                    }
                    if (plikwyA.IsMatch(args[i])) // jesli argument pasuje do regexa pliku wyjsciowego to args[i] staje sie plikiem wyjsciowym
                    {
                        plikwy = args[i];
                    }
                    if (formatA.IsMatch(args[i])) // jesli argument pasuje do regexa formatu to args[i] staje sie formatem
                    {
                        format = args[i];
                    }
                }
            }
            else // jesli sa 3 argumenty to je przypisujemy do zmiennych
            {
                plikwe = args[0];
                plikwy = args[1];
                format = args[2];
            }


// Otwarcie pliku wejsciowego i przegladanie zawartosci
            var lines = File.ReadLines(plikwe);
            foreach (var line in lines)
            {
                var tabs = line.Split(",");
                if (tabs.Length != 9)
                {
                    File.AppendAllText(plikerror, "Niepoprawne informacje o studencie - "+line); //logujemy bledne informacje o studencie do pliku log.txt
                }
                else
                {
                    //sprawdzenie czy jest jakas pusta kolumna
                    for (int i = 0; i < tabs.Length; i++)
                    {
                        if (tabs[i]=="")
                        {
                            File.AppendAllText(plikerror, "Niepełne informacje o studencie - " + line); //logujemy niepelne informacje o studencie do pliku log.txt
                        }
                    }
                   


                    //sprawdzenie czy sie powtarza osoba
                    //dodanie do HashSet
                }

            }








        }
    }
}
