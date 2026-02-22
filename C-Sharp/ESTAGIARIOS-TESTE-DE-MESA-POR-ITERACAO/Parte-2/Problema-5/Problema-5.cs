using System;

class Programa
{
    static void Main()
    {
        Console.Write("Saldo atual: ");
        double saldoAtual = double.Parse(Console.ReadLine());

        Console.Write("Taxa: ");
        decimal percentual = decimal.Parse(Console.ReadLine());

        Console.Write("Periodo: ");
        int tempo = int.Parse(Console.ReadLine());

        decimal taxa = percentual / 100;

        double valorPresente = calculaJuros(saldoAtual, taxa, tempo);

        Console.Write($"Valor Inicial Investido: {valorPresente:F2}");
    }

    static double calculaJuros (double valorFuturo, decimal taxaJuros, int periodo )
    {
        return valorFuturo / Math.Pow(1 + (double)taxaJuros, periodo);
    }
}
