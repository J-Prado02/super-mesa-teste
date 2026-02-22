using System;

class Programa
{
    static void Main()
    {
        DateTime inicio = new DateTime(2026, 2, 22);
        DateTime fim = inicio.AddMonths(8).AddDays(10);

        TimeSpan periodo = fim - inicio;
        int dias = periodo.Days;

        double meses = dias / 30.0; // mês comercial

        Console.Write("Saldo Inicial: ");
        double saldoInicial = double.Parse(Console.ReadLine());

        Console.Write("Taxa (% ao mês): ");
        decimal percentual = decimal.Parse(Console.ReadLine());

        decimal taxa = percentual / 100;

        double saldoFinal =
            saldoInicial * Math.Pow(1 + (double)taxa, meses);

        Console.WriteLine($"\nPeríodo Início: {inicio:d}");
        Console.WriteLine($"Período Final: {fim:d}");
        Console.WriteLine($"Total de dias: {dias}");
        Console.WriteLine($"Meses equivalentes: {meses:F4}");

        Console.WriteLine($"\nSaldo Final: {saldoFinal:F2}");
    }
}