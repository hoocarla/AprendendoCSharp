using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

            double investimento = 1000;

            //rendimento de 0,5% (0.005) ao mês;

            //mês 1
          //  investimento = investimento + investimento * 0.005;
            //mes 2
            //investimento = investimento + investimento * 0.005;
            //mes 3
           // investimento = investimento + investimento * 0.005;


           // Console.WriteLine(investimento);

            int mes = 1;

            while (mes <= 12) //'enquanto' o mes foi maior ou igual a 12, executa o que está dentro do bloco;
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês  " + mes + " você tem R$ " + investimento);
                //sig. também mes += 1 ou mes++;
                mes = mes + 1; // O loop retornará à condição e, dessa vez, mes será igual a 2! Esse processo se repetirá até que mes seja igual a 13, a condição não será mais respeitada, então o laço de repetição será encerrado e conseguiremos prosseguir com o resto do código até o fim.
            }

            Console.WriteLine("Tecle entre para fechar...");
            Console.ReadLine();
        }
    }
}
