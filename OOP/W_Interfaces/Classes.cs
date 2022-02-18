namespace W_Interfaces
{
    public class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar() { }

        public void Sacar() { }

        public void Saldo() { }

        public void PagarConta() { }
    }

    public interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
