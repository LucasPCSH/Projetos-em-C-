﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class ForEach
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Volkswagen", "Hyundai" };
            foreach (string i in carro)
            {
                Console.WriteLine(i);
            }
        }
    }
}
