using System;

namespace HandsOn_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataNascimento = "07/04/1966";
            var dataTipada = DateTime.Parse(dataNascimento);
            Console.WriteLine($"Data de nascimento da pessoa: {dataTipada}");

            var dataAtual = DateTime.Now;
            Console.WriteLine($"{dataAtual}");

            var diferenca = dataAtual - dataTipada;
            Console.WriteLine($"A quantidade de Dias que a pessoa viveu foi de: {diferenca.Days}");
        }
    }
}
