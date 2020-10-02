using System;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        int a, op, i = 1; 
        string salada, maionese;
        caixa c = new caixa();

        do
        {
            //Uma lanchonete possui os seguintes produtos lanche de carne(R$20) ou de frango(R$16), batata frita(R$6) e refrigerante(R$4).
            //Os lanches podem ou não vir com salada. Acréscimo de R$2
            //Os lanches e a batata podem ou não vir com maionese.Acréscimo de R$1

            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU");
            Console.WriteLine("\n\tSEU CAIXA ATÉ AGORA: R$" + c.vlt);

            Console.WriteLine("\nSelecione um Item:\n");
            Console.WriteLine("\n1 - Para 1x Lanche de Carne                                                              R$20,00\n");
            Console.WriteLine("\n2 - Para 1x Lanche de Frango                                                             R$16,00\n");
            Console.WriteLine("\n3 - Para 1x Batata Frita                                                                 R$6,00\n");
            Console.WriteLine("\n4 - Para 1x Refrigerante                                                                 R$4,00\n\n");
            op = Convert.ToInt16(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("\nVoce selecionou 1x Lanche de Carne\n");
                    c.vlt = c.vlt + 20.00;

                    Console.Write("\nDeseja Adicionar Salada ao seu Lanche? (Acréscimo de R$ 2,00) (S / N) ");
                    salada = Console.ReadLine();
                    if (salada == "S" || salada == "s") { Console.WriteLine("Foi Adicionado Salada ao seu Lanche "); c.vlt = c.vlt + 2.00; }

                    Console.Write("\nDeseja Adicionar Maionese ao seu Lanche? (Acréscimo de R$ 1,00) (S / N) ");
                    maionese = Console.ReadLine();
                    if (maionese == "S" || maionese == "s") { Console.WriteLine("Foi Adicionado Maionese ao seu Lanche "); c.vlt = c.vlt + 1.00; }

                    Console.WriteLine("\nDeseja mais algum Item? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;

                case 2:
                    Console.WriteLine("\nVoce selecionou 1x Lanche de Frango \n");
                    c.vlt = c.vlt + 16.00;

                    Console.Write("\nDeseja Adicionar Salada ao seu Lanche? (Acréscimo de R$ 2,00) (S / N) ");
                    salada = Console.ReadLine();
                    if (salada == "S" || salada == "s") { Console.WriteLine("Foi Adicionado Salada ao seu Lanche "); c.vlt = c.vlt + 2.00; }

                    Console.Write("\nDeseja Adicionar Maionese ao seu Lanche? (Acréscimo de R$ 1,00) (S / N) ");
                    maionese = Console.ReadLine();
                    if (maionese == "S" || maionese == "s") { Console.WriteLine("Foi Adicionado Maionese ao seu Lanche "); c.vlt = c.vlt + 1.00; }



                    Console.WriteLine("\nDeseja mais algum Item? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;

                case 3:
                    Console.WriteLine("\nVoce selecionou 1x Batata-Frita  \n");
                    c.vlt = c.vlt + 6.00;

                    Console.Write("\nDeseja Adicionar Maionese ao seu Lanche? (Acréscimo de R$ 1,00) (S / N) ");
                    maionese = Console.ReadLine();
                    if (maionese == "S" || maionese == "s") { Console.WriteLine("Foi Adicionado Maionese a sua Batata "); c.vlt = c.vlt + 1.00; }
                    Console.WriteLine("\nDeseja mais algum Item? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;

                case 4:

                    Console.WriteLine("\nVoce selecionou 1x Refrigerante\n");
                    c.vlt = c.vlt + 4.00;
                    Console.WriteLine("\nDeseja mais algum Item? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;
                default:
                    Console.WriteLine("\nValor inválido");
                    i = 0;
                    break;
            }




        } while (i != 0);
        Console.WriteLine("\nQuantidade de Combos Vendidos:");
        Console.WriteLine("\nValor Total: R$" + c.fechaCaixa(c.vlt));
        Console.WriteLine("\n\nPrecissione Enter para Sair");
        Console.ReadLine();
    }
    public class caixa
    {
        public double vlt = 0;

        public double fechaCaixa(double vlt)
        {
            double total;
            total = vlt;
            return total;
        }
    }

}



