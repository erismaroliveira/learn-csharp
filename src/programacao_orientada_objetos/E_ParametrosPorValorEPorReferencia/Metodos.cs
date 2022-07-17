using System;

namespace E_ParametrosPorValorEPorReferencia
{
    public class Metodos
    {
        // Passagem de Parâmetro por Valor
        
        public void Aumentar(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final por valor é: " + valor);
        }

        // Passagem de Parâmetro por Referência

        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final por referência é: " + valor);
        }
    }
}
