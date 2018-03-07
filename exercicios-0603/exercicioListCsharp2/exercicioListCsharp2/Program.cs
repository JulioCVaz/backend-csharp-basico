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
            Console.WriteLine("digite um numero: ");
            int number = int.Parse(Console.ReadLine());

            int calc = number * 2;

            Console.WriteLine("O dobro do valor de " + number + " é : " + calc);
            Console.ReadKey();

        }
    }
}
