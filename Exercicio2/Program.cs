using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Elabore um programa que calcule a equação de segundo grau utilizando a formula de Bhaskara.
            //OBS: O usuário deve entrar com ‘a’, ‘b’ e ‘c’ e devemos calcular o valor de ‘x1’ e ‘x2’.
            //Formula: 𝐷𝑒𝑙𝑡𝑎=𝑏²−4∗𝑎∗𝑐 𝑥= (−𝑏 ±√𝐷𝑒𝑙𝑡𝑎)/(2∗𝑎)

            int a, b, c;
            double delta, x1, x2;

            Console.WriteLine("Digite o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = Math.Sqrt((b * b) - (4 * a * c)); // cálculo Δ = 𝑏²−4∗𝑎∗𝑐 e extraindo em seguida a raíz do delta 
            x1 = (-b + delta) / (2 * a); // cálculo 𝑥1 = (−𝑏 +√𝐷𝑒𝑙𝑡𝑎)/(2∗𝑎)
            x2 = (-b - delta) / (2 * a); // cálculo 𝑥2 = (−𝑏 -√𝐷𝑒𝑙𝑡𝑎)/(2∗𝑎)

            Console.WriteLine("\nx1 = " + x1 + "\nx2= " + x2);

            Console.ReadKey();
        }
    }
}
