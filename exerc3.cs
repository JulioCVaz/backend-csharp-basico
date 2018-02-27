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
            string nome;
            int idade;
            double peso;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write(nome + ", Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write(nome + ", Digite seu peso: ");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("\n********* Informações digitadas  *********");
            Console.WriteLine("{0} tem {1} anos de idade e pesa {2:N3}kg", nome, idade, peso);
            
            Console.ReadKey();

        }
    }
}
