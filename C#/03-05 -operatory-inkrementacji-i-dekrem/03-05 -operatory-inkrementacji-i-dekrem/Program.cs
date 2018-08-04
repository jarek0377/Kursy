using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05__operatory_inkrementacji_i_dekrem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, wynik;
            wynik = ++x * 3;
            Console.WriteLine(x);
            Console.WriteLine(wynik);
            Console.ReadKey();

        }
    }
}
