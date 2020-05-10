using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace clasa_elevi
{
    public class MyOrder : IComparer<Elev>
    {
        public int Compare(Elev a, Elev b)
        {
            int compareAverage = a.Average.CompareTo(b.Average);
            if (compareAverage == 0)
            {
                int compareLastName = a.Name.CompareTo(b.Name);
                if (compareLastName == 0)
                {
                    return a.Name.CompareTo(b.Name);
                }
                return compareLastName;
            }
            return compareAverage;
        }

    }
}
