using System;

namespace R_ClassesAbstratas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Veiculo v = new Veiculo(); Classe abstrata, não pode instanciar objeto, só pode ser herdada
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
        }
    }
}
