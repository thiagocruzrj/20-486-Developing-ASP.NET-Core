using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o operador: ");

            string switchCase = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            switch(switchCase)
            {
                case "+":
                    Sum(v1, v2);
                    break;
                case "-":
                    Sub(v1, v2);
                    break;
                case "*":
                    Mult(v1, v2);
                    break;
                case "/":
                    Div(v1, v2);
                    break;
                default:
                    Console.WriteLine("Operator doesn't exist");
                    break;
            }
        }
        
        static void Sum(float v1, float v2)
        {
            Console.WriteLine($"O resultado da soma de {v1} + {v2} é: {v1 + v2}");
        }

        static void Sub(float v1, float v2)
        {
            Console.WriteLine($"O resultado da subtração de {v1} - {v2} é: {v1 - v2}");
        }

        static void Mult(float v1, float v2)
        {
            Console.WriteLine($"O resultado da multiplicação de {v1} * {v2} é: {v1 * v2}");
        }

        static void Div(float v1, float v2)
        {
            Console.WriteLine($"O resultado da divisão de {v1} / {v2} é: {v1 / v2}");
        }
    }
}