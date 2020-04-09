using System;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace numere_rationale
{
    class rational
    {
        private int nr, nu;

        public rational() { nr = 2; nu = 3; }
        public rational(int a, int b)
        { nr = a; nu = b; simplificare(); }

        public void afisare()
        {
            if (nu == 1) Console.Write(nr);
            else Console.Write(nr + "/" + nu);
        }

        public override string ToString()
        {
            if (nu == 1) return nr.ToString();
            else return nr + "/" + nu;
        }

        public static rational operator +(rational a, rational b)
        { return new rational(a.nr * b.nu + a.nu * b.nr, a.nu * b.nu); }

        public static rational operator -(rational a, rational b)
        { return new rational(a.nr * b.nu - a.nu * b.nr, a.nu * b.nu); }

        public static rational operator *(rational a, rational b)
        { return new rational(a.nr * b.nr, a.nu * b.nu); }

        public static rational operator /(rational a, rational b)
        { return new rational(a.nr * b.nu, a.nu * b.nr); }

        public static bool operator <(rational a, rational b)
        { return a.nr * b.nu < a.nu * b.nr; }

        public static bool operator >(rational a, rational b)
        { return a.nr * b.nu > a.nu * b.nr; }

        public static bool operator <=(rational a, rational b)
        { return !(a > b); }

        public static bool operator >=(rational a, rational b)
        { return !(a < b); }

        public static bool operator ==(rational a, rational b)
        { return a.nr * b.nu == a.nu * b.nr; }

        public static bool operator !=(rational a, rational b)
        { return !(a == b); }

        public static int comparare(rational a, rational b)
        {
            if (a < b) return -1;
            else if (a == b) return 0;
            else return 1;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private int cmmdc(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b; a = b; b = r;
            }
            return a;
        }

        private void simplificare()
        {
            int c = cmmdc(Math.Abs(nr), Math.Abs(nu));
            nr = nr / c; nu = nu / c;
            if (nr * nu < 0)
            {
                nr = -Math.Abs(nr); nu = Math.Abs(nu);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rational z, w, s, d, p, c;
            bool e;

            z = new rational(2,3);//primul numar 2/3;
            w = new rational(1,5);//al doilea numar 1/5;
            s = new rational();//suma numerelor
            d = new rational();
            p = new rational();
            c= new rational();
            
            
            z.afisare();
            Console.WriteLine();
            w.afisare();
            Console.WriteLine();
            s = z + w;
            Console.WriteLine();
            Console.WriteLine("Suma numerelor este = {0} ",s.ToString());
            d = z - w;
            Console.WriteLine("difernta este= {0} ",d.ToString());
            p = z * w;
            Console.WriteLine("produsul numerelor este= {0} ",p.ToString());
            c = z / w;
            Console.WriteLine("catul numerelor este= {0} ",c.ToString());
            e = z < w;
            Console.WriteLine(e);
            rational.comparare(z, w);
            Console.WriteLine(rational.comparare(z,w));

        }
}
}
