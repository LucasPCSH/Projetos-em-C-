using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class SystemLinqNS
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 1, 4, 7, 8, };
            Console.WriteLine(numeros.Max()); //Exibe o maior valor dentro do vetor
            Console.WriteLine(numeros.Min()); //Exibe o valor mínimo dentro do vetor
            Console.WriteLine(numeros.Sum()); //Exibe a soma que está dentro do vetor
        }
    }
}
