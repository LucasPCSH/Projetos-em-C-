using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class ForEachSortNum
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40 };
            Array.Sort(numeros);
            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
