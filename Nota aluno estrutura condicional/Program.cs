using System;
using System.Globalization;

namespace Nota_aluno_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("Sua nota final é: " + soma.ToString("F1",CultureInfo.InvariantCulture));

            if (soma < 60)
            {
                Console.WriteLine("Você está reprovado");
            }
            //if  (soma >= 60)
            else
            { 
                Console.WriteLine("Você está Aprovado");
            }
        }
    }
}
