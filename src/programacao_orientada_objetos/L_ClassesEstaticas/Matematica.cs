namespace L_ClassesEstaticas
{
    public static class Matematica
    {
        public static int taxa = 10;

        public static int Adicionar(int valor)
        {
            return taxa + valor;
        }

        public static int Diminuir(int valor)
        {
            return taxa - valor;
        }
    }
}
