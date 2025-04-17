using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var faturamentoPorEstado = new Dictionary<string, decimal>
        {
            { "SP", 67836.43M },
            { "RJ", 36678.66M },
            { "MG", 29229.88M },
            { "ES", 27165.48M },
            { "Outros", 19849.53M }
        };
        decimal faturamentoTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            faturamentoTotal += valor;
        }
        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in faturamentoPorEstado)
        {
            decimal percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}

