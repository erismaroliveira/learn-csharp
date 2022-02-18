using System;

namespace I_Delegates
{
    public class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;

            conta(10, 2);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Somar;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}
