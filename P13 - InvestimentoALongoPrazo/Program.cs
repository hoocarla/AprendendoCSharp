using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___InvestimentoALongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 - Investindo a Longo prazo");
            //Primeiramente, declaramos as variáveis fatorRendimento e investimento: 
            double fatorRendimento = 1.005;
            double investimento = 1000;

            //Em seguida, temos uma estrutura for responsável por aumentar o fator de rendimento em 0,1% ao ano, por 5 anos: 
            for (int anos = 1; anos <= 5; anos++) //sua variável de inicialização é int anos = 1, sua condição para continuar executando é anos <= 5 e seu contador deve ser incrementado de uma e uma unidade, anos++. 
            {
                //temos outro for, responsável por aumentar o investimento em si, conforme o fator de rendimento:
                for (int mes =1; mes <= 12; mes++) //obs: Vale lembrar que o fatorRendimento só será incrementado depois que esse segundo for finalizar sua execução.
                {
                    investimento *= fatorRendimento;
                }
                fatorRendimento = fatorRendimento + 0.001;
             
            }
                Console.WriteLine("Depois de 5 anos você terá " + investimento);
                Console.ReadLine();
            }
        }
    }
 