using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persoana> p = new List<Persoana>();
            p.Add(new Persoana("mihut", "sorin",
                "13.04", "mihut@gmail.com"));
           
            p.Add(new Persoana("ciucle", "ioana", "13/12",
                "ioan@gmail.com"));
            p.ForEach(delegate (Persoana a
                ) { Console.WriteLine($"{a.nume} {a.prenume}" +
                    $" {a.datanasterii} {a.email}"); });
            Console.ReadKey();
        }
    }
}
