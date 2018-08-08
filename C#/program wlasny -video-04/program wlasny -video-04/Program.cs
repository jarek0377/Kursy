using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_wlasny__video_04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool czyspelniakryteria;
            double wiek=18 , kwota=20 , tak=1 , nie=3 ;
            Console.WriteLine("witam Cie na koncercie...wstep od 18 lat,cena 20 zl");
            Console.Write("Podaj ile masz lat..");
            wiek = double.Parse(Console.ReadLine());
            Console.Write("Podaj kwote...");
            kwota = double.Parse(Console.ReadLine());
            Console.Write("jestes trzezwy ?  ..tak-1 , nie-2(false)      ...");
            tak = double.Parse(Console.ReadLine());
            czyspelniakryteria = ((wiek >= 18 & kwota >= 20) &&tak == 1| nie==2); 
            Console.WriteLine("czy spelniasz kryteria -{0}", czyspelniakryteria);
            Console.ReadKey();
          
        }
         
    }
}
