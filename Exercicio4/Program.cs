using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 – Crie um gerador de e-mail que solicite o nome do usuário completo
            // e mostre ao final o email: nome@fatec.sp.gov.br

            string name, posFS;
            int posF;

            Console.WriteLine("Digite seu nome completo: ");
            name = Console.ReadLine();

            posF = name.IndexOf(" "); // selecionar o primeiro espaço
            posFS = name.Substring(0, posF); // selecionar o primeiro nome
            posFS = posFS.Trim().ToLower(); // remover os espaços e deixar os caracteres minusculos
            Console.WriteLine("Email: " + posFS + "@fatec.sp.gov.br");

            Console.ReadKey();
        }
    }
}
