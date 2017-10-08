using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 5;
            int liczba2 = -3;
            double liczba3 = -3.2334;
            double liczba4 = 6.323;
            float liczba5 = -9;
            float liczba6 = 12.2323f;

            Console.WriteLine(liczba1 - liczba2);
            Console.WriteLine(liczba1 + liczba3);
            Console.WriteLine(liczba1 * liczba5);
            Console.WriteLine(liczba4 / liczba6);
            Console.WriteLine(liczba2 % liczba5);
            Console.ReadKey();
        }
    }
}
