using System;

namespace S_ClassesSealed
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Veiculo v = new Veiculo(); Classe abstrata, não pode instanciar objeto, só pode ser herdada
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            Caminhonete cam = new Caminhonete();
        }
    }
}
