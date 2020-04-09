using System;

namespace operatii_numere_complexe
{
    class Program
    {
        public class complex
        {
            // consideram numarul complex de forma algebrica z = x + y * i
            public int x;
            public int y;
            public static complex suma(complex numarComplex1, complex numarComplex2)
            {
                complex sum = new complex();

                sum.x = numarComplex1.x + numarComplex2.x;
                sum.y = numarComplex1.y + numarComplex2.y;

                return sum;
            }
            public static complex diferenta(complex numarComplex1, complex numarComplex2)
            {
                complex dif = new complex();
                //z1-z2=(a1-a2)-(b1-b2)*i
                dif.x = numarComplex1.x - numarComplex2.x;
                dif.y = numarComplex1.y - numarComplex2.y;

                return dif;
            }
            public static complex produsul(complex numarComplex1, complex numarComplex2)
            {
                complex prod = new complex();
                //z1*z2=(a1a2-b1b2)+(a1b2+a2b1)*i
                //(a+bi)(c+di) = (ac−bd) + (ad+bc)i
                prod.x = (numarComplex1.x*numarComplex2.x)-(numarComplex1.y*numarComplex2.y);
                prod.y = (numarComplex1.x*numarComplex2.y) + (numarComplex2.x*numarComplex2.y);

                return prod;
            }
            static void Main(string[] args)
            {
                complex z, w, s,d,p;

                z = new complex();
                w = new complex();
                s = new complex();
                d = new complex();
                p = new complex();
                z.x = 3; z.y = 2;
                w.x = 2; w.y = 2;

                s = suma(z,w);
                d = diferenta(z, w);
                p = produsul(z, w);

                Console.WriteLine("S = {0} + ({1} * i)", s.x.ToString(), s.y.ToString());
                Console.WriteLine("D = {0} + ({1} * i)", d.x.ToString(), d.y.ToString());
                Console.WriteLine("P = {0} + ({1} * i)", p.x.ToString(), p.y.ToString());
                Console.ReadKey();
            }
        }
    }
}