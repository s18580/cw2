using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    class Student
    {
        public String Imie, Nazwisko, Kierunek, Tryb, Index, Mail, ImieMatki, ImieOjca;
        public DateTime Data;

        public Student(String[] tab)
        {
            Imie = tab[0];
            Nazwisko = tab[1];
            Kierunek = tab[2];
            Tryb = tab[3];
            Index = tab[4];
            Data = DateTime.Parse(tab[5]);
            Mail = tab[6];
            ImieMatki = tab[7];
            ImieOjca = tab[8];
        }

    }
}
