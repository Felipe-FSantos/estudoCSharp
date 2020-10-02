using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        int i, x, ord, ord2;
        ord2 = 0;

        int[] v = new int[8];

        for (i = 1; i < 8; i++)
        {
            Write("Digite o " + i + "º valor: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < 5; i++)
        {
            for (x = i + 1; x < 5; x++)
            {
                if (v[i] > v[x])
                {
                    ord = v[i];
                    v[i] = v[x];
                    v[x] = ord;
                }
            }
        }

        for (i = 0; i < 5; i++)
        {
            for (int y = i + 1; y < 5; y++)
            {
                if (v[i] == v[y])
                {

                    Console.WriteLine("\nO valor " + v[y] + " repetiu");


                }

                else
                {
                    ord2 = ord2 + 1;
                }
            }

        }
    }
}
    

