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
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            double calc = Math.Pow((number),2);

            Console.WriteLine("O quadrado do valor de " + number + " é: " + calc);
            Console.ReadKey();

        }
    }
}
