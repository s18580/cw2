using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    class MyComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase.Equals($"{x.Imie} {x.Nazwisko} {x.Index}",
                                                                    $"{y.Imie} {y.Nazwisko} {y.Index}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.InvariantCultureIgnoreCase.GetHashCode($"{obj.Imie} {obj.Nazwisko} { obj.Index}");
        }
    }
}
