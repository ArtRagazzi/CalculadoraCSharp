using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado = 0;

            string operacao;
            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Operação (+ - * /)");
            operacao = Console.ReadLine();
            Console.WriteLine("Digite o Segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Digite uma operação Valida (+ - * /)");
                    break;
            }

            Console.WriteLine("O resultado de {0} {1} {2} é {3}", num1, operacao, num2, resultado);

            Console.ReadKey(true);
        }
    }
}
