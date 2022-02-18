using System;

namespace D_MetodosComParametros
{
    public class Metodos
    {
        // Métodos com parâmetros

        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma dos valores é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }
    }
}
