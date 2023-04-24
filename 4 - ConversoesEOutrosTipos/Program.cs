using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoesEOutrosTipos
{
    using System;
    class Programa
    {
        static void Main(string[] args)
        {
            //Tipos de Variaveis:

            double salario; //variaveis com ponto flutuante;
            salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro;
            salarioInteiro = (int)salario; // Aqui fazemos o **Casting, que é uma forma de converter uma variável do tipo double para inteiro.
            Console.WriteLine(salarioInteiro);

            long x; //que guarda cerca de 64 bits de informação. Com ele podemos armazenar valores ainda maiores, como 2000000000000000000;
            x = 2000000000000000000;
            Console.WriteLine(x);

            short y; //que armazena até 16 bits (ou seja, tem um limite menor). 
            y = 15000;
            Console.WriteLine(y);


            float altura = 1.62f; //Para alertar o compilador que estamos cientes da situação e declaramos um tipo float propositalmente, usamos o sufixo f após o valor 1.62
            Console.WriteLine(altura);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
