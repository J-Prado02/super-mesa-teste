using System;

class Programa
{
    static void Main()
    {
       Console.Write("valorPresente: ");
       double capitalInicial = double.Parse(Console.ReadLine()); 

       Console.Write("Taxa: ");
       decimal percentual = decimal.Parse(Console.ReadLine());

       Console.Write("Período (Meses ou Ano): ");
       int tempo = int.Parse(Console.ReadLine());

       decimal taxa = percentual / 100;

       double montanteFinal = calcularJuros(capitalInicial, taxa, tempo);

       Console.WriteLine($"Valor Final: {montanteFinal:F2}");


    }

    static double calcularJuros(double valorPresente, decimal taxaJuros, int periodo)
    {
        return valorPresente * Math.Pow(1 + (double)taxaJuros, periodo);
    }
}