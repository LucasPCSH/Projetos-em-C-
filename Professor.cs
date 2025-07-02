using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JajaAtividade
{
    internal class Professor
    {
        string nome = "Jailson";
        string nacionalidade = "Brasileira";
        string idade = "40";
    public static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor2 = new Professor();
            Professor professor3 = new Professor();
            Console.WriteLine(professor.nome);
            Console.WriteLine(professor2.nacionalidade);
            Console.WriteLine(professor3.idade);
        }
    }
}
