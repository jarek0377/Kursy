using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przelicz_walute
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x=10;
            //double z=2.5;
            //double y=1d/2;
            //Console.WriteLine(y);

            //Przeliczanie kursu walutowego 
            double F, C;
            Console.WriteLine("Podaj kwote Euro");
            F = double.Parse(Console.ReadLine());
            C = F * 4.263;
            Console.WriteLine(C);
            Console.WriteLine(" wartosc w zlotych ,Milego Dnia");
            Console.ReadKey();



        }
    }



}
