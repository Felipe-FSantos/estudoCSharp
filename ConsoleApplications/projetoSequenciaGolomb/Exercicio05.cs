using System;

namespace Exercicio05
{
    class Program
    {
        static int Golomb(int n)
        {            
            if (n == 1)
                return 1;
            else
            {
                return 1 + Golomb(n - Golomb(Golomb(n - 1)));
            }
            
        }

        static void showGolomb(int n)
        {

            for (int i = 1; i <= n; i++)
                Console.Write(Golomb(i) + ", ");
        }

        public static void Main()
        {
            int n;

            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Sequência de Golomb: ");
            showGolomb(n);

        }
    }
}
