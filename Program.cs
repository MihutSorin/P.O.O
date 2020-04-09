using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatii_matrici
{
    class Operatii
    {
        int[,] a;
        int[,] b;

        public Operatii()
        {
        }

        public Operatii(int[,]a, int[,]b)
        {
            this.a = a;
            this.b = b;
        }
        public int[,]Suma(int[,]a,int[,]b)
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];
                        for (int k = 0; k < a.GetLength(0); k++)
                            for (int j = 0; j < a.GetLength(1); j++)
                                res[k, j] = a[k, j] + b[k, j];

                    return res;
        }

        public int[,] Multiply(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int size = b.GetLength(0);
            int cols = b.GetLength(1);
            int[,] m = new int[rows, cols];

            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int ret = 0;
                    for (int x = 0; x < size; x++)
                    {
                        ret += a[k, x] * b[x, j];
                    }
                    m[k, j] = ret;
                }
            }
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = {
                        {1,2,3,4},
                        {5,6,7,8},
                        {9,1,2,3}
                    };
            int[,] b = {
                        {1,2,3,4},
                        {1,2,3,4},
                        {1,2,3,4 } };
            Operatii x = new Operatii();
           print(x.Suma(a, b));
            Console.WriteLine();
            print(x.Multiply(a, b));
            Console.ReadKey();
        }

        private static void print(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



