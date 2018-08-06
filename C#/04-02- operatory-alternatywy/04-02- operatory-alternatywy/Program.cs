using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02__operatory_alternatywy
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 3;
            bool wynik;
            wynik = (x >= 2| x++ >= 4);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
