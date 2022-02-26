using System;

namespace Calculadora

{
    class Program
    {
        static void Main()
        {
            double num1 = 0, num2 = 0;
            string escolhaNum="";
            Console.WriteLine("Digite o primeiro numero: ");
            escolhaNum = Console.ReadLine();
            num1 = double.Parse(escolhaNum);
            Console.WriteLine("Digite o segundo numero: ");
            escolhaNum = Console.ReadLine();
            num2 = double.Parse(escolhaNum);
            Console.WriteLine("Adição: {0}",num1 + num2);
            Console.WriteLine("Subtração: {0}", num1 - num2);
            Console.WriteLine("Multiplicação: {0}", num1 * num2);
            Console.WriteLine("Divisão: {0}", num1 / num2);
            Console.ReadKey();
        }
    }
}


