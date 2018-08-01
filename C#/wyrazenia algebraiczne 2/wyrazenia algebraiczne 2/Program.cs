using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyrazenia_algebraiczne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x=10;
            //double z=2.5;
            //double y=1d/2;
            //Console.WriteLine(y);

            //Przeliczanie temperatury ze skali Fahrenheita na Celcjusza
            double F, C;
            Console.WriteLine("Podaj temp.w stopniach Fahrenheita");
            F = double.Parse(Console.ReadLine());
            C = 5.0 / 9 * (F - 32);
            Console.WriteLine(C);
            Console.ReadKey();



          

        }

    
        }
    }
