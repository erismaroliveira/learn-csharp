using System;

namespace O_PropriedadesDaClasseGetSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            t.Nome = "Erismar";
            t.Idade = 28;

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);

            Console.ReadKey();
        }
    }
}
