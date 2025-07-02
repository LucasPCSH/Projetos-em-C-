using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class ForEachSort
    {
        public static void Main(string[] args)
        {
            string[] carros = {"Volvo", "Chevrolet", "Ford", "BMW" };
            Array.Sort(carros);
            foreach (string veiculo in carros)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}
