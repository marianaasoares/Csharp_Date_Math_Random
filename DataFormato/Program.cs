using System;

namespace DataFormato
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAtual = DateTime.Now;
            Console.WriteLine($"Formato d: {dataAtual:d}");
            Console.WriteLine($"Formato D: {dataAtual:D}");
            Console.WriteLine($"Formato f: {dataAtual:f}");
            Console.WriteLine($"Formato F: {dataAtual:F}");

            var dataAtualMenos5dias = dataAtual.AddDays(-5);

            Console.WriteLine($"Formato dd: {dataAtualMenos5dias:%d}");
            Console.WriteLine($"Formato dd: {dataAtualMenos5dias:dd}");
            Console.WriteLine($"Formato ddd: {dataAtualMenos5dias:ddd}");
            Console.WriteLine($"Formato dddd: {dataAtualMenos5dias:dddd}");
        }
    }
}
