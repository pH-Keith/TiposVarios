﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort banana = 120;
            ushort apple = 3000;
            int diff = apple - banana;
            bool verify = true;
            char trademark = '\u0025';
            Console.WriteLine("Banana = " + banana);
            Console.WriteLine("Apple = " + apple);
            Console.WriteLine("banana - apple = " + diff);
            Console.WriteLine("Another way to do banana - apple = " + (apple - banana) + trademark);
            if(verify == true || banana == 1)
            {
                Console.WriteLine("IT WOOOOOOOORKED!");
            }
            Console.ReadKey();
        }
    }
}
    