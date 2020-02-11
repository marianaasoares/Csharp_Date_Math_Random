using System;

namespace HandsOn_DataNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataNascimentoString = "30/07/1998";

            var dataNascimento = DateTime.Parse(dataNascimentoString);

            Console.WriteLine($"Dia da semana de nascimento foi: {dataNascimento:dddd}");
        }
    }
}
