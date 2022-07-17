using System;

namespace R_ClassesAbstratas
{
    public abstract class Veiculo
    {
        public abstract string Cor { get; set; }

        public string Marca { get; set; }

        public abstract void Acelerar();

        public virtual void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
