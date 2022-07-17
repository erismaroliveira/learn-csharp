using System;

namespace T_MembrosSealed
{
    public class Humano
    {
        protected virtual void Olhos() { Console.WriteLine("Humano.Olhos"); }
        protected virtual void Cabelos() { Console.WriteLine("Humano.Cabelos"); }
    }

    public class Pessoa : Humano
    {
        sealed protected override void Olhos() { Console.WriteLine("Pessoa.Olhos.Verdes"); }
        protected override void Cabelos() { Console.WriteLine("Pessoa.Cabelos.Castanhos"); }
    }

    public class Homem : Pessoa
    {
        // Attempting to override Olhos causes compiler error CS0239.
        // protected override void Olhos() { Console.WriteLine("Pessoa.Olhos.Verdes"); }

        // Overriding Cabelos is allowed.
        protected override void Cabelos() { Console.WriteLine("Homem.Cabelos.Pretos"); }
    }
}
