using System;

namespace O_Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.cliente = "João";
            //c.saldo = 100;

            //===== Operação de Depósito ==================

            c.Depositar(500);

            //===== Operação de Saque =====================

            //c.saldo -= 10; // Taxa saque (Encapsular)
            c.Sacar(200);

            //===== Resultado Saldo Atual =================

            Console.WriteLine("Cliente: " + c.cliente);
            Console.WriteLine("Saldo: " + c.GetSaldo());

            Console.ReadKey();
        }
    }
}
