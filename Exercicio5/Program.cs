using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5– DESAFIO(Crie um gerador de e-mail que solicite o nome do usuário completo
            //e mostre ao final o email: nome.ultimosobrenome@fatec.sp.gov.br

            string name, posLS, posFS;
            int posF, posL;

            Console.WriteLine("Digite seu nome completo: ");
            name = Console.ReadLine();

            posL = name.LastIndexOf(" "); // selecionar o primeiro espaço de tras para frente
            posLS = name.Substring(posL); // selecionar o ultimo nome
            posLS = posLS.Trim().ToLower(); // remover os espaços e deixar os caracteres minusculos

            posF = name.IndexOf(" "); // selecionar o primeiro espaço
            posFS = name.Substring(0, posF); // selecionar o primeiro nome
            posFS = posFS.Trim().ToLower(); // remover os espaços e deixar os caracteres minusculos

            Console.WriteLine("Email: " + posFS + "." + posLS + "@fatec.sp.gov.br");

            Console.ReadKey();
        }
    }
}
