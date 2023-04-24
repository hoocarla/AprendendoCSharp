using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EncadeadoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 14 - Encadeando For");
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for(int contadorColunas =0; contadorColunas < 10; contadorColunas++)
                {
                    Console.Write("*");
                    if (contadorColunas >= contadorLinhas)
                        break; //palavra reservada que 'para' o programa quando a condição é respeitada;
                }
                Console.WriteLine(); //pula linhas
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
