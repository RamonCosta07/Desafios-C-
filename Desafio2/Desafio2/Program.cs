using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcule e imprima a variável MEDIA
             * com 5 dígitos após o ponto decimal
             * e com um espaço em branco antes e
             * depois da igualdade.
             */
            double a, b, media;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            a = Math.Round(a, 2);
            b = Math.Round(b, 2);

            media = Math.Round(((a * 3.5) + (b * 7.5)) / (3.5 + 7.5), 5);

            Console.WriteLine($"MEDIA = {media}");
        }
    }
}
