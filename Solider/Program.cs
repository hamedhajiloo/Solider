using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solider
{
    class Program
    {
        static void Main(string[] args)
        {


            int n =int.Parse( Console.ReadLine());
           // var g = 2 Math (n + 1);

            var len = (2 ^ (n + 1)) - 1;
            char[,] res = new char[len,len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    res[0,j] = '#';
                    res[i,0] = '#';
                    res[i,len - 1] = '#';
                    res[len - 1,j] = '#';
                }
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(res[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
