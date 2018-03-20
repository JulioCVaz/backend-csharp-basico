using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2Diagrama
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        // get and sets peso
        public float getPeso()
        {
            return peso;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }

        // get and sets idade
        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        // get and sets membros
        public int getMembros()
        {
            return membros;
        }

        public void setMebros(int membros)
        {
            this.membros = membros;
        }

        // metod locomover
        // quando nao informar o tipo de retorno do metodo usar void
        public void locomover()
        {
            //TODO
        }

        public void alimentar()
        {
            //TODO
        }

        public void emitirSom()
        {
            //TODO
        }

    }
}
