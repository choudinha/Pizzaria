using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Extra
    {
        private double baconValor = 3.00;
        private double bordaValor = 5.00;
        private int bordaTempo = 5;

        public int Adicional { get; set; }

        public Extra(int add)
        {
            Adicional = add;
        }

        public double ObterValor()
        {
            double valor = 0;

            if (Adicional == 1)
                valor = baconValor;

            else if (Adicional == 2)
                valor = bordaValor;
            
            return valor;
        }

        public double ObterTempo()
        {
            double tempo = 0;

            if (Adicional == 2)
                tempo = bordaTempo;
            return tempo;
        }


    }
}
