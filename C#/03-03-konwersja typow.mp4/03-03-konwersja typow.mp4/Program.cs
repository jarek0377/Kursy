using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03_konwersja_typow.mp4
{
    class Program
    {
        static void Main(string[] args)
       
        {
            const int liczbaMiesiecy = 12;
            int liczbaSamochodow;
            double sredniaSprzedaz;
            Console.WriteLine("Podaj roczną sprzedaż samochodów : ");
            liczbaSamochodow = int.Parse(Console.ReadLine());
            sredniaSprzedaz = (double)liczbaSamochodow / (double)liczbaMiesiecy;
            Console.WriteLine(sredniaSprzedaz);
            Console.ReadKey();


            
        }
    }
}
