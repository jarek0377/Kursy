﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_03_zlozone_wyrazenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            bool wynik;
            wynik = ((x == 1 || x == 3 || x == 5) && y <= 1);
            Console.WriteLine(!wynik);
            Console.ReadKey();

        }
    }
}
