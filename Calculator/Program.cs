using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da soma de {v1} + {v2} é: {v1 + v2}");
        }
    }
}
