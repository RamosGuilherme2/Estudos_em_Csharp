using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string json = System.IO.File.ReadAllText(("Faturamento.json"));

        var arquivoFaturamento = JsonSerializer.Deserialize<List<RegistroDeFaturamento>>(json);
        var diasValidos = arquivoFaturamento.Where(d => d.Faturamento > 0).ToList();
        var menorFaturamento = diasValidos.Min(d => d.Faturamento);
        var maiorFaturamento = diasValidos.Max(d => d.Faturamento);
        var mediaMensal = diasValidos.Average(d => d.Faturamento);

        var diasAcimaMedia = diasValidos.Count(d => d.Faturamento > mediaMensal);

        // Exibir resultados
        Console.WriteLine($"Menor faturamento: R${menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento: R${maiorFaturamento:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}
class RegistroDeFaturamento
{
    public int Dia { get; set; }
    public decimal Faturamento { get; set; }
}

