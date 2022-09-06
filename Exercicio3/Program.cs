using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 – Elaborar um programa que permita que o usuário escreva seu nome completo.
            // Mostrar na tela: Nome e o sobrenome separadamente. O conteúdo da string do caractere cinco ao dez.
            // Substituir todos os caracteres ‘a’ pelo ‘o’.

            string name, nameChange, nameCut, nameSel, posF;
            int posL;

            Console.WriteLine("Digite o seu nome completo: ");
            name = Console.ReadLine();
            posL = name.IndexOf(" "); // receber a posição do primeiro espaço
            posF = name.Substring(0, posL); // selecionar o primeiro caractere até o primeiro espaço
            nameCut = name.Substring(posL); // selecionar o conteúdo a partir do primeiro espaço
            nameCut = nameCut.Trim(); // remover o espaço inicial
            nameSel = name.Substring(4, 6); // selecionar apenas o conteúdo da string do 5° ao 10° caractere
            nameChange = name.Replace("a", "o"); // substituir todos os caracteres ‘a’ pelo ‘o’.
            Console.WriteLine("Primeiro nome: " + posF);
            Console.WriteLine("Sobrenome: " + nameCut);
            Console.WriteLine("Nome completo trocando 'a' por 'o': " + nameChange);
            Console.WriteLine("Apenas do 5º caractere ao 10º: " + nameSel);

            Console.ReadKey();
        }
    }
}
