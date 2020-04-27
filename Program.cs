using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ordonare_fisier
{
    class Program
    {
        private static IEnumerable<string> lines;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"..\..\data.txt");
            StreamWriter sw = new StreamWriter(@"..\..\out.txt");
            string line = sr.ReadToEnd();
            string[] s = line.Split(';');
            List<string> x = new List<string>();
            foreach (string a in s)
            {
                x.Add(a);
            }
            x.Sort();
            foreach (string var in x)
            {
                Capitalizat(var);
                sw.WriteLine(var);
            }
          
            sr.Close();
            sw.Close();

            
            Console.ReadKey();
        }

        private static void Capitalizat(string line)
        {
            Char[] ca = line.ToCharArray();

            foreach (Match m in Regex.Matches(line, @"\b[a-z]"))
            {
                ca[m.Index] = Char.ToUpper(ca[m.Index]);
            }

            Console.WriteLine(new string(ca));
        }
    }
}
