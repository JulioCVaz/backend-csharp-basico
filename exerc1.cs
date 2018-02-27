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
            string nome = "Júlio", sobrenome = "Vaz", completo;

            completo = nome +" "+sobrenome;

            Console.WriteLine(completo);
            Console.ReadKey();


            Console.WriteLine("(01) " + nome + sobrenome);
            Console.WriteLine("(02) " + sobrenome);
            Console.WriteLine("(03) " + nome + " possui " + nome.Length + "caracteres");
            Console.WriteLine("(04) " + sobrenome + "possui " + nome.Length + "caracteres");
            Console.WriteLine("(05) " + completo + " possui " + completo.Length + "caracteres");
            Console.WriteLine("(06) " + nome + " nome em minusculo " + nome.ToLower());
            Console.WriteLine("(07) " + sobrenome + " sobrenome em maisuculo " + sobrenome.ToUpper());
            Console.WriteLine("(08) " + nome + " eh igual " + sobrenome + "=" + nome.Equals(sobrenome));
            Console.WriteLine("(09) " + nome + " substring iniciado na posicao 2 e pegando 2 caracteres = " + nome.Substring(2,1));
            Console.ReadKey();

        }
    }
}
