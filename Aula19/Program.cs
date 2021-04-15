using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula19, Calculo de Diferença do produto, tipo int 
            //Jonas Valereo - Técnico em informática

            //Declarando as variaveis tipo int

            int A, B, C, D, DIFERENCA;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o 1 número: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 número: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3 número: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4 número: ");
            D = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declarando a variavel diferença

            DIFERENCA = (A * B - C * D);

            //imprimir saida de dados no console, e método WhriteLine, concatenação


            Console.WriteLine("A diferença do Produto é: " + DIFERENCA);
            Console.WriteLine();
            Console.WriteLine("Tente de novo!!!");


            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
