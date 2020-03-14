using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cw2
{
    [Serializable()]
    class Student
    {
        //[XmlElement(ElementName = "InneNazwa")]
        public string Imie;
        //[XmlAttribute(AttributeName = "InnaNazwa")]
        public string Nazwisko;
        public string Kierunek, Tryb, Index, Mail, ImieMatki, ImieOjca;

        public DateTime Data;

        public Student(string[] tab)
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
