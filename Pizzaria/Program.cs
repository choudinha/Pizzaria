using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] saboresExtra = new string[3];
            double valorFinal = 0;
            double tempoFinal = 0;
            Console.WriteLine("Por favor Escolha o tamanho da pizza");
            Console.WriteLine("1 - Pequena");
            Console.WriteLine("2 - Média");
            Console.WriteLine("3 - Grande");

            int tamanho = int.Parse(Console.ReadLine());
            string tamanhoPizza = " ";
            switch(tamanho)
            {
                case 1:
                    tamanhoPizza = "Pequena";
                    break;
                case 2:
                    tamanhoPizza = "Média";
                    break;
                case 3:
                    tamanhoPizza = "Grande";
                    break;
            }

            Console.WriteLine("Por favor Escolha o sabor da pizza");
            Console.WriteLine("1 - Calabresa");
            Console.WriteLine("2 - Marguerita");
            Console.WriteLine("3 - Portuguesa");
            int sabor = int.Parse(Console.ReadLine());
            string saborPizza = " ";
            switch (sabor)
            {
                case 1:
                    saborPizza = "Calabresa";
                    break;
                case 2:
                    saborPizza = "Marguerita";
                    break;
                case 3:
                    saborPizza = "Portuguesa";
                    break;
            }

            Pizza pizza = new Pizza(sabor, tamanho);

            double valorResult = pizza.ObterValor();
            double tempoResult = pizza.ObterTempo();
            valorFinal += valorResult;
            tempoFinal += tempoResult;

            Console.WriteLine("Deseja algum adicional(Extra bacon/sem cebola/borda recheada) para a pizza?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int verificaExtra = int.Parse(Console.ReadLine());

            if (verificaExtra == 1)
            {
                HashSet<int> adicionais = new HashSet<int>();
                //int i = 0;
                int contadorAdc = 0;
                bool desejaContinuar = true;
                bool sair = false;
               

                do
                {
                    if (desejaContinuar == true)
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            Console.WriteLine("Qual adicional voce deseja?");
                            Console.WriteLine("1 - Extra Bacon");
                            Console.WriteLine("2 - Borda Recheada");
                            Console.WriteLine("3 - Sem Cebola");

                            int adicional = int.Parse(Console.ReadLine());

                            if (adicionais.Contains(adicional))
                            {
                                Console.WriteLine("Opcional ja escolhido");
                                Console.WriteLine("Selecione outro");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                i--;
                            }
                            else
                            {
                                switch (adicional)
                                {
                                    case 1:
                                        saboresExtra[i] = "Extra Bacon";
                                        break;
                                    case 2:
                                        saboresExtra[i] = "Borda Recheada";
                                        break;
                                    case 3:
                                        saboresExtra[i] = "Atenção! sem cebola!";
                                        break;
                                }
                                
                                adicionais.Add(adicional);
                            }
                            Console.WriteLine("Deseja continuar adicionado extras?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");
                            int continua = int.Parse(Console.ReadLine());
                            if (adicionais.Count == 3 && continua == 1)
                            {
                                Console.WriteLine("Voce ja adicionou todos extras possiveis");
                                Console.WriteLine("Prosseguindo com o pedido....");
                            }
                            if (continua == 2 || i == 2)
                            {
                                desejaContinuar = false;
                                i = 2;
                                //adicionais.Add(3);


                            }
                        }
                    }
                } while (desejaContinuar == true && adicionais.Count != 3);

                foreach (int a in adicionais)
                {
                    Extra extra = new Extra(a);
                    double valorExtra = extra.ObterValor();
                    double tempoExtra = extra.ObterTempo();
                    valorFinal += valorExtra;
                    tempoFinal += tempoExtra;
                }
            }
            Console.WriteLine("-------------------- RESUMO DO PEDIDO --------------------");
            Console.WriteLine("Tamanho da pizza: "+ tamanhoPizza);
            Console.WriteLine("Sabor da pizza: " + saborPizza);
            
            for(int i = 0; i <=2 ; i++){
                if (i == 0)
                Console.WriteLine("Adicionais:");
              
                Console.WriteLine(i+1 +"-" + saboresExtra[i]); 
            }

            Console.WriteLine("Valor Final: "+ valorFinal+" Reais");
            Console.WriteLine("tempo de preparo é: " + tempoFinal + " minutos"); 
            Console.WriteLine("----------------------------------------------------------");
            Console.ReadKey();

        }

    







    }
}




