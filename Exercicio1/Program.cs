using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 – Desenvolva um programa para calcular a área, diâmetro e perímetro do círculo.

            double pi = 3.14, ar, di, pe, r;

            Console.WriteLine("Digite a medida do raio do círculo: ");
            r = Convert.ToDouble(Console.ReadLine());

            ar = pi * (r * r); //cálculo área
            di = 2 * r; //cálculo diâmetro
            pe = 2 * pi * r; //cálculo perímetro

            Console.WriteLine("\nÁrea: " + ar + "\nDiâmetro: " + di + "\nPerímetro: " + pe);
            Console.ReadKey();
        }
    }
}
