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
            Console.WriteLine("Digite o valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor C: ");
            int c = int.Parse(Console.ReadLine());


            double calc = ((Math.Pow((a), 2)) * 5 - c) / (b - (a % 4));

            Console.WriteLine("Valor : "+ calc);
            Console.ReadKey();

        }
    }
}
