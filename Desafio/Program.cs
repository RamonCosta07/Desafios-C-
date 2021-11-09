using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia quatro valores inteiros A, B, C e D
             * A seguir, calcule e mostre a diferença
             * do produto de A e B pelo produto
             * de C e D segundo a fórmula:
             * DIFERENCA = (A * B - C * D).
             */

            int a, b, c, d;   //declare suas variaveis             

            Console.WriteLine("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de d: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENCA = {a * b - c * d}");
            Console.ReadKey();
        }
    }
}