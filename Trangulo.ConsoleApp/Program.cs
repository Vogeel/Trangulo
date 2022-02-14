using System;

namespace Trangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int l1,l2,l3;
                string lados;
                Console.WriteLine("Tipos de triangulos");
                volta:
                Console.WriteLine("Digite os valores do triangulo (lados) para saber qual tipo ele é separado por espaços(L1 L2 L3)");
                
                lados = Console.ReadLine();
                try
                {
                    l1 = int.Parse(lados.Split(' ')[0]);
                    l2 = int.Parse(lados.Split(' ')[1]);
                    l3 = int.Parse(lados.Split(' ')[2]);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deu algum erro, digite novamente");
                    Console.ResetColor();
                    goto volta;
                }
                if (l1 == l2 && l2== l3 && l3==l1)
                {
                    Console.WriteLine("Seu triangulo é um triangulo equilátero, pois todos os lados são iguais");
                }
                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("Seu triangulo é um triangulo escaleno, pois todos os lados são diferentes");
                }
                else if (l1 == l2 && l1 != l3 || l3==l2 && l3 != l1 || l2 == l1 && l2 != l3 || l2 == l3 && l2 != l1 || l1 == l3 && l1 != l2)
                {
                    Console.WriteLine("Seu triangulo é um trianglo isóceles, pois dois lados são iguais e um é diferente");
                }

                Console.ReadKey();
            

            } while (true);
        }
    }
}
