using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int resultadoDivisao = 0;

            Console.Write("Digite o Primeiro Número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            resultadoDivisao = primeiroNumero / segundoNumero;

            Console.WriteLine("A Divisão Total é: {0}", resultadoDivisao);
        }
    }
}
