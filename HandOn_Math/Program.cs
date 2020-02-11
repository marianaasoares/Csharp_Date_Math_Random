using System;

namespace HandOn_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° número inteiro: ");
            var primeiro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número inteiro: ");
            var segundo = int.Parse(Console.ReadLine());

            var maiorNumero = Math.Max(primeiro, segundo);

            Console.WriteLine($"O maior número entre os que foram ditos é: {maiorNumero}");

        }
    }
}
