using System;

namespace HandOn_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogando dado...");
            var dado = new Random();
            var jogada = dado.Next(1, 7);

            Console.WriteLine($"Pontuação da jogada: {jogada}");
        }
    }
}
