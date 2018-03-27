using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3Diagrama
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;
        private double horista;

        public double getPrecoHora(){
            return precoHora;
        }

        public void setPrecoHora(double precoHora) {
            this.precoHora = precoHora;
        }

        public double getHorasTrabalhadas() {
            return precoHora;
        }

        public void setHorasTrabalhadas(double horasTrabalhadas){
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double vencimento()
        {
            
            return horista = (precoHora*horasTrabalhadas)*22;

        }
    }
}
