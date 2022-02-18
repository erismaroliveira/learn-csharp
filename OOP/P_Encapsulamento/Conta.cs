namespace P_Encapsulamento
{
    public class Conta
    {
        private string _cliente;
        private double _saldo;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if(value != "Erismar" && value != "Logan")
                {
                    _cliente = "Visitante";
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }
        }

        public double Saldo
        {
            get
            { 
                return _saldo;
            }

            private set
            {
                _saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            Saldo -= 10; // Taxa saque (Encapsulado)
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
