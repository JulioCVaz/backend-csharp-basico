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
            
           const double dolarHoje = 3.20;

           Console.WriteLine("Digite o valor: ");
           double real = double.Parse(Console.ReadLine());

           double calc = dolarHoje * real;
           Console.WriteLine("Valor do Dólar: " + dolarHoje);
           Console.WriteLine("Saldo Atual: " + real);
           Console.WriteLine("Seu Saldo em reais: " + calc);
           Console.ReadKey();
        }
    }
}
