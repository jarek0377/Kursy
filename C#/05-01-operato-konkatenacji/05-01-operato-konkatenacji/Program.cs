using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_operato_konkatenacji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię");
            string tekst = Console.ReadLine();
            tekst = "Cześć"  + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length);
            Console.ReadKey();
        }
    }
}
