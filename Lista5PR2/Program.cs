using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Escolha um exercício: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int num1;
                    Console.WriteLine("Digite um valor: ");
                    num1 = int.Parse(Console.ReadLine());

                    for (int p = 1; p <= num1; p++)
                    {
                        Console.WriteLine(p);
                    }

                    Console.ReadKey();
                    break;
                case 2:
                    int num2;
                    Console.WriteLine("Digite um valor: ");
                    num2 = int.Parse(Console.ReadLine());

                    for (int y = 1; y <= num2; y++)
                    {
                        if (y % 2 == 0)
                        {
                            Console.WriteLine(y);
                        }
                    }

                    Console.ReadKey();
                    break;
                case 3:
                    int num3;

                    Console.WriteLine("Digite um valor que seja menor que 1000: ");
                    num3 = int.Parse(Console.ReadLine());

                    for (int u = 1000; u >= num3; u--)
                    {
                        if (u % 2 == 0)
                        {
                            Console.WriteLine(u);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    int i;

                    for (int num4 = 0; num4 < 200;)
                    {
                        Console.WriteLine("Digite um valor: ");
                        i = int.Parse(Console.ReadLine());

                        if (i > 0)
                        {
                            num4 += i;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    int num5;

                    Console.WriteLine("Digite um valor: ");
                    num5 = int.Parse(Console.ReadLine());

                    for (int t = 1; t <= num5; t++)
                    {
                        if (num5 % t == 0)
                        {
                            Console.WriteLine(t);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    int n1, menor, maior;

                    Console.WriteLine("Digite um número: ");
                    n1 = int.Parse(Console.ReadLine());

                    menor = n1;
                    maior = n1;

                    for (int r = 0; r < 9; r++)
                    {
                        Console.WriteLine("Digite um número: ");
                        n1 = int.Parse(Console.ReadLine());

                        if(n1 < menor)
                        {
                            n1 = menor;
                        }
                        else if(n1 > maior)
                        {
                            n1 = maior;
                        }
                    }
                    Console.WriteLine("O maior número é: " + maior);
                    Console.WriteLine("O menor número é: " + menor);
                    Console.ReadKey();
                    break;
                case 7:
                    int num7 = -1, soma = 0;

                    for (; num7 == 0;)
                    {
                        Console.WriteLine("Digite um valor: ");
                        num7 = int.Parse(Console.ReadLine());

                        if(num7 % 2 == 0)
                        {
                            soma = soma + num7;
                        }
                        else
                        {
                            soma += num7;
                        }
                    }
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }
}
