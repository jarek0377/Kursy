﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_operatoey_koniunkcji
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiek = 19, kwota = 20;
            bool kino;
            kino = (wiek >= 18 && kwota >= 20);
            Console.WriteLine(kino);
            Console.WriteLine(kwota);
            Console.ReadKey();

        }
    }
}
