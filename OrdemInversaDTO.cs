using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    public class OrdemInversaDTO
    {

        private int[] vetorEntrada;
        private int qtdeElementos;

        public int[] VetorEntrada
        {
            get { return vetorEntrada; }
            set { vetorEntrada = value; }
        }

        public int QtdeElementos
        {
            get { return qtdeElementos; }
            set { qtdeElementos = value; }
        }

        public OrdemInversaDTO()
        {
        }
    }
}