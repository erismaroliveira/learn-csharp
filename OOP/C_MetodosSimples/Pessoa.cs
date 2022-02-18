using System;

namespace C_MetodosSimples
{
    public class Pessoa
    {
        // Atributos e Campos

        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Métodos Simples

        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome);
        }
    }
}

