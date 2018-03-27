using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3Diagrama
{
    class Assalariado : Empregado
    {
        private double salario;
        private double salarioFinal;

        public double getSalario() {
            return salario;
        }

        public void setSalario(double salario) {
            this.salario = salario;
        }

        public override double vencimento() { 
            
            return salarioFinal = salario;
        }

    }
}
