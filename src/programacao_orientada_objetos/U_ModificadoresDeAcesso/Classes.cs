namespace U_ModificadoresDeAcesso
{
    public class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }
    }

    public class Humano
    {
        protected string nome; // Pode ser acessado nas classes derivadas (que herdam desta classe)
        private string sobrenome; // Só pode ser acessado nesta classe
    }

    public class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            //sobrenome = "";
        }
    }

    public class Pessoa
    {
        internal string nome; /* Internal, o elemento só pode ser utilizado dentro do mesmo Assembly (Aplicação), por exemplo, 
                                se for criado uma DLL este metodo/elemento não estaria disponível por ser importado ou seja,
                                não faria parte da mesma aplicação. */

        public void Metodo() { }
    }
}
