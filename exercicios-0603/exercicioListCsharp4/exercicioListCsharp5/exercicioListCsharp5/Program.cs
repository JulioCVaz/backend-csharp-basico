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
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int maior = 18;
            string maiorIdade = "Você é maior de idade !";
            string menorIdade = "Você é menor de idade !";

            String testeIdade = (idade >= maior) ? maiorIdade : menorIdade;
            Console.WriteLine(testeIdade);
            Console.ReadKey();
        }
    }
}
