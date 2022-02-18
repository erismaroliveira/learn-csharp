namespace H_UtilizandoOTermoThis
{
    public class Acessar
    {
        string senha = "abc123";

        public bool Login(string senha)
        {
            return this.senha == senha ? true : false;
        }
    }
}
