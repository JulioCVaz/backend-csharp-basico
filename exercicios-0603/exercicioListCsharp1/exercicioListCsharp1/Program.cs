using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1 C#
           Console.WriteLine("Digite seu nome: ");
           String nome = Console.ReadLine();

           Console.WriteLine("Digite sua idade: ");
           int idade = int.Parse(Console.ReadLine());

           Console.WriteLine("Dgite sua cidade: ");
           String cidade = Console.ReadLine();

           Console.WriteLine(nome);
           Console.WriteLine(idade);
           Console.WriteLine(cidade);

           Console.ReadKey();
        }
    }
}
