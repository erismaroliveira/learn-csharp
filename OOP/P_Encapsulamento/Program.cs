using System;

namespace P_Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Erismar";
            //c.Saldo = 100; // Não é possivel, somente de forma interna

            //===== Operação de Deposito ==================

            c.Depositar(500);

            //===== Operação de Saque =====================

            //c.saldo -= 10; // Taxa saque (Encapsular)
            c.Sacar(200);

            //===== Resultado Saldo Atual =================

            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
