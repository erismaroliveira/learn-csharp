namespace F_MetodosComRetorno
{
    public class Metodos
    {
        // Métodos com retorno de valores

        public string MontaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            return caractere; // Não precisou converter, porque a conversão é implícita.
        }
    }
}
