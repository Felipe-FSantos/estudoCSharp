using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean c = false;
            while (!c)
            {
                Console.WriteLine("Digite o palindrome inicial(fim para terminar): ");
                String s = Console.ReadLine();
                if (s.Length < 100)
                {
                    if (s.Equals("fim"))
                        c = true;
                    else 
                       
                    if(verfPalindromo(s) != true)
                    {
                        Console.WriteLine("Maior palíndrome é: " + maiorPalindrom(s));
                    }
                    else { Console.WriteLine("Não é Palindrome"); }
                }
                else
                    Console.WriteLine("A cadeia de caracteres precisa ter no máximo 100 elementos");

            }
            string maiorPalindrom(string s)
            {

                var palindrom = string.Empty;

                for (var i = 0; i < s.Length && s.Length - i > palindrom.Length / 2; i++)
                {
                    var e = i; //Esquerda

                    var z = i; //Direita

                    while (z + 1 < s.Length && s[z + 1] == s[e])
                        z++;

                    var palinZe = (palindrom.Length - z + e) / 2;

                    while (e - palinZe >= 0 && z + palinZe <= s.Length - 1 && verfPalindromo(s.Substring(e - palinZe, z + 2 * palinZe - e + 1)))
                    {
                        palindrom = s.Substring(e - palinZe, z + 2 * palinZe - e + 1);
                        palinZe++;
                    }
                }
                return palindrom;
            }

            static bool verfPalindromo(string s)
            {
                for (var i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                        return false;
                }

                return true;
            }
        }
    }
}

