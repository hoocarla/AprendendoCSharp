using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 -  criando variaveis ");
            int idade;

            idade = 27;

            Console.WriteLine("Minha idade é " + idade); //concatenando 

            idade = 27 - 5;
            Console.WriteLine(idade); //saida da variavel: 23

            idade = (5 - 2) * 1;
            Console.WriteLine(idade);


            Console.WriteLine("Tecle entre para fechar...");
            Console.ReadLine(); //Console.ReadLine() Retorna o valor da linha inteira;
        }
    }
}

