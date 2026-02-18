using System;

class Programa
{
    static void Main()
    {
        Console.Write("Valor Presente: ");
        double capitalInicial = double.Parse(Console.ReadLine());

        Console.Write("Taxa: ");
        decimal percentual = decimal.Parse(Console.ReadLine());

        Console.Write("Perído (anos): ");
        int tempo = int.Parse(Console.ReadLine());

        decimal taxa = percentual / 100;

        double montanteFinal = calcularJuros(capitalInicial, taxa, tempo);

        Console.Write($"| Valor Presente: {capitalInicial:F2}   | Taxa de Juros: {percentual:F2} %   | Perído: {tempo} Ano(s)  | Renda: {montanteFinal:F2}");



    }

    static double calcularJuros(double valorPresente, decimal taxaJuros, int periodo)
    {
        return valorPresente * Math.Pow(1 + (double)taxaJuros, periodo);
    }
}
