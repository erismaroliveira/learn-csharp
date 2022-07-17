namespace O_Encapsulamento
{
    public class Conta
    {
        public string cliente;
        public double saldo;

        public void Sacar(double valor)
        {
            saldo -= 10;
            saldo -= valor; // Taxa saque (Encapsulado)
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}
