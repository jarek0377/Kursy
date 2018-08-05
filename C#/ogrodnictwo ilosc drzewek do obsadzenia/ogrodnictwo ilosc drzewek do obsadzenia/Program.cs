using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrodnictwo_ilosc_drzewek_do_obsadzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            double ilosc;
            double dlugoscodcinka, odleglosc;
            Console.WriteLine("Podaj dlugość odcinka do obsadzenia(w metrach)");
            dlugoscodcinka= double .Parse(Console.ReadLine());
            Console.WriteLine("Podaj odleglość między drzewkami(w cm)");
            odleglosc=double.Parse(Console.ReadLine());
            ilosc = dlugoscodcinka  / odleglosc * 100;
            Console.WriteLine("Zakup :") ;
            Console.WriteLine(ilosc);
            Console.ReadKey();

        }
    }       

}



