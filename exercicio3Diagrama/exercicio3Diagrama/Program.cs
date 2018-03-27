using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3Diagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            //HORISTA
            Horista hora = new Horista();

            hora.setNome("Júlio");
            hora.setSobrenome("Vaz");
            hora.setCpf("123.465.789-10");
            hora.setHorasTrabalhadas(9);
            hora.setPrecoHora(22.0);
            Console.WriteLine(" \n=== Horista === " + hora.ToString() + "\nSalario por mês: " + hora.vencimento()+" R$");
            Console.ReadKey();

            //ASSALARIADO
            Assalariado assalario = new Assalariado();

            assalario.setNome("José");
            assalario.setSobrenome("Willian");
            assalario.setCpf("123.654.987-01");
            assalario.setSalario(1600.00);
            Console.WriteLine("\n=== Assalariado === " + assalario.ToString() + "\nSalario por mês: " + assalario.vencimento() + " R$");
            Console.ReadKey();

            //COMISSIONADO

            Comissionado comissao = new Comissionado();

            comissao.setNome("Maria");
            comissao.setSobrenome("Luiza");
            comissao.setCpf("321.654.987-20");
            comissao.setTaxaComissao(22.00);
            comissao.setTotalVenda(200);
            Console.WriteLine("\n=== Comissinado === " + comissao.ToString() + "\nSalario naquele mês: " + comissao.vencimento() + " R$");
            Console.ReadKey();



        }
    }
}
