using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 - Caracteres e Textos");

            char letra = 'a'; //pra definir um caractere usa-se aspas simples, ao contrario, estarimos declarando um texto;
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(65 + 1); //fazeendo um *casting*, transformando o numero inteiro 65 numa variável do tipo char:
            Console.WriteLine(letra);

            //Textos
            string PrimeiraFrase = "Ana Carla Gomes "; //Para armazenar frases ou qualquer sequência de texto maior que uma letra, usamos o tipo string.
            Console.WriteLine(PrimeiraFrase + 2022);
            //String Vazia é permitida e gera um espaço
            string vazia = "";
            Console.WriteLine(vazia);

            //Caracter vazio não é permitido:
            //letra = '';

            string cursos = @"Cursos disponiveis: 
            - Java 
            - C#
            -Python"; //com esse @ podemos colocar esse texto um abaixo do outro;
            Console.WriteLine(cursos);

            Console.WriteLine("Tecle entre para fechar...");
            Console.ReadLine();
        }
    }
}