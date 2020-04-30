using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace elevi
{
    class Elev
    {
        public string nume;
        public string prenume;
        public double media;
        private int numar_note;
        private double[] note;
        internal static void loadFromFile(string fileName)
        {
            TextReader dataLoad = new StreamReader(fileName);
            string buffer;
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                Console.WriteLine(buffer.ToLower());
                
            }
        }
        public Elev(string lastname, string firstname, int marks_number, double[] marks)
        {
            nume = lastname;
            prenume = firstname;
            media = 0;
            numar_note = marks_number;
            note = marks;

            for (int i = 0; i < numar_note; i++)
                media += note[i];

            media /= numar_note;
        }

       
    }
    class Program
    {

        static void Main(string[] args)
        {
           
          // Elev.loadFromFile(@"..\..\data.txt");
            StreamReader sr = new StreamReader(@"..\..\data.txt");
            string linii = sr.ReadToEnd();
            Console.WriteLine(sr.ReadToEnd());
            Capitalizat(linii);
            Console.WriteLine();
           // string line = sr.ReadToEnd();
            string[] s = linii.Split(' ');
            List<string> x = new List<string>();
            foreach (string a in s)
            {
                x.Add(a);
              
            }
           
            x.Sort();

            List<int> y= new List<int>();
            foreach (int b in linii)
            {
                y.Sort();

            }

            y.Sort();
            Console.ReadKey();
        }
        internal static void Capitalizat(string line)
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
