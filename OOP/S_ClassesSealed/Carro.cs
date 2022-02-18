using System;

namespace S_ClassesSealed
{
    public class Carro : Veiculo
    {
        public override string Cor { get; set; } // Abstrato, é obrigatório implementar

        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou o motor do carro!");
        }

        public override void Acelerar() // Abstrato, é obrigatório implementar
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar() // Virtual, não é obrigatório implementar
        {
            Console.WriteLine("O Carro parou!");
        }
    }
}
