using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3Diagrama
{
    class Empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private double salarioMinimo = 954;

        public string getNome(){
            return nome;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getSobrenome() {
            return sobrenome;
        }

        public void setSobrenome(string sobrenome) {
            this.sobrenome = sobrenome;
        }

        public string getCpf() {
            return cpf;
        }

        public void setCpf(string cpf) {
            this.cpf = cpf;
        }

        public virtual double vencimento()
        {
            return salarioMinimo;
        }


        public virtual string ToString() {

            return "\nNome: " + nome + "\nSobrenome: " + sobrenome + "\nCPF: " + cpf;

        }

    }
}
