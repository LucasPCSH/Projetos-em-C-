using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class Matriz2D
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 5, 3 }, { 2, 4, 6 } };
            Console.WriteLine($"{numeros[0, 2]}\n");
            Console.WriteLine($"{numeros[1, 2]}\n");
            Console.WriteLine($"{numeros[0, 1]}\n");
        }
    }
}
