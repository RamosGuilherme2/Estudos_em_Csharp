using System;
class Program
{
    static bool Fibonacci(int numero)
    {
        int a = 0, b = 1, c = 0;
        while (c < numero)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c == numero || numero == 0;
    }
    static void Main(string[] args)
    {
        string loop;

        do
        {
            Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            if (Fibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }

            Console.WriteLine("Deseja verificar outro número? (Digite 'sim' para continuar ou qualquer outra coisa para sair)");
            loop = Console.ReadLine().ToLower();

        } while (loop == "sim");

        Console.WriteLine("Programa encerrado. Até mais!");
    }
}

