using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;

            string textoAdicional;

            if(acompanhado == true) //se João estiver acompanhado, vamos armazenar a mensagem "João está acompanhado";
            {
                 textoAdicional = "João está acompanhado!";
            }

            else //senão guardaremos "João não está acompanhado"
            {
                textoAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado) 
            {
                Console.WriteLine(textoAdicional);
                Console.WriteLine("Pode entrar!");
            }

            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }
    }
}
