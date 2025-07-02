using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class ForEach02
    {
        public static void Main(string[] args)
        {
            string[] aluno = { "Késia", "Ferreira", "André", };
            foreach (string sala in aluno)
            {
                Console.WriteLine(sala);
            }
        }
    }
}
