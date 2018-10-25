using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Pizza
    {
        //valor das pizza
        private double pequenaValor = 20.00;
        private double mediaValor = 30.00;
        private double grandeValor = 40.00;

        //tempo das pizzas
        private int pequenaTempo = 15;
        private int mediaTempo = 20;
        private int grandeTempo = 25;

        public int Sabor { get; set; }
        public int Tamanho { get; set; }

        public Pizza(int sabor, int tamanho)
        {
            Sabor = sabor;
            Tamanho = tamanho;
        }
        public double ObterValor()
        {
            double valor;
            if (Tamanho == 1)
                valor = pequenaValor;
            else if (Tamanho == 2)
                valor = mediaValor;
            else
                valor = grandeValor;

            return valor;
        }
        public double ObterTempo()
        {
            double tempo;
            if (Tamanho == 1)
                tempo = pequenaTempo;
            else if (Tamanho == 2)
                tempo = mediaTempo;
            else
                tempo = grandeTempo;

            if (Sabor == 3)            
                tempo += 5; // tempo portuguesa            
            return tempo;
        }
    }

    

}