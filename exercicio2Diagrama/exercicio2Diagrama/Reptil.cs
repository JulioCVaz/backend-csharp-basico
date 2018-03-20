using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2Diagrama
{
    class Reptil : Animal
    {
        private string corEscama;

        public string getCorEscama()
        {
            return corEscama;
        }

        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }
    }
}
