using System;
using System.Globalization;

namespace Exercicio_Dolar_01
{
    class Program
    {
        public const double real = 5.36;

        static void Main(string[] args)
        {
            float result, dolar;

            Console.Write("Digite o valor em Dolar: ");
            dolar = float.Parse(Console.ReadLine());
            result = (float) (dolar * real);
            Console.Write("\nO Valor em Real é: " );
            Console.WriteLine(result.ToString("00.00"));
        }
    }
}
