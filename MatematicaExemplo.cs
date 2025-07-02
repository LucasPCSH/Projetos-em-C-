using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class MatematicaExemplo
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o valor que está entre os dois números digitados (x, y).
            
            Console.WriteLine(Math.Max(5, 10));

            //Math.MIn mostra o valor que está na faixa dos dois números digitados (x,y)
            
            Console.WriteLine(Math.Min(5, 10));

            //Math.sqrt apresenta o valor de uma raiz quadrada

            Console.WriteLine(Math.Sqrt(64));

            // Math.Abs retorna o valor absoluto de um número;

            Console.WriteLine(Math.Abs(-4.7));

            //Math.Round arredonda o valor do número;

            Console.WriteLine(Math.Round(9.99));


        }
    }
}
