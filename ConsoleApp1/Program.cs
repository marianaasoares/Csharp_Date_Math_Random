using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inicioDoAno = new DateTime(2020, 1, 1); // dia, mês, ano
            var inicioDoAnoComHora = new DateTime(2020, 1, 1, 12, 0, 0); // dia, mês, ano - data, hora e segundo

            var trintaDiasAposInicioDeAno = inicioDoAno.AddDays(30.5);
            Console.WriteLine($"{trintaDiasAposInicioDeAno}");

            var dataAtual = DateTime.Now;
            Console.WriteLine($"{dataAtual}");

            //Verificar a quantidade de Dias

            var diferenca = dataAtual - inicioDoAnoComHora;
            // diferenca = dataAtual.Subtract(inicioDoAnoComHora); outra forma de fazer

            Console.WriteLine($"Quantidade de dias entre o início do ano e hoje: {diferenca.Days}");
            Console.WriteLine($"Quantidade de dias entre o início do ano e hoje com horas: {diferenca.TotalDays}");
        }
    }
}
