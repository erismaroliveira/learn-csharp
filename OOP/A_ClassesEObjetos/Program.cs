namespace A_ClassesEObjetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse objeto1 = new MinhaClasse();
            OutraClasse objeto2;

            // objeto1 é do tipo MinhaClasse
            // objeto2 é do tipo OutraClasse

            objeto1 = null;
            objeto2 = new OutraClasse();
        }
    }

    public class OutraClasse
    {
        // Alteração de Teste GIT
    }
}
