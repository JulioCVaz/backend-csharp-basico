using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2Diagrama
{
    class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        //  get e set corPelo
        public string getCorPelo()
        {
            return corPelo;
        }

        public void setCorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }

        // get e set raca
        public string getRaca()
        {
            return raca;
        }

        public void setRaca(string raca)
        {
            this.raca = raca;
        }


    }
}
