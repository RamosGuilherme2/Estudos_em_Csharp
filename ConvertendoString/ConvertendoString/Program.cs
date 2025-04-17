using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a string que deseja inverter:");
        string entrada = Console.ReadLine();
        string invertida = InverterString(entrada);
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string input)
    {
        char[] caracteres = input.ToCharArray();

        // Inverção manual de caracteres
        for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[j];
            caracteres[j] = temp;
        }
        return new string(caracteres);
    }
}
