using System;

namespace M_MembrosEstaticos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Erismar";
            p1.idade = Pessoa.CalcularIdade(1994);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}
