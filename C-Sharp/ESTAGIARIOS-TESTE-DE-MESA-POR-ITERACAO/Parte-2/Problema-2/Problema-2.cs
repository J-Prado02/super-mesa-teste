using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Programa
{
    static void Main()
    {
        Console.Write("Valor Presente: ");
        double capitalInicial = double.Parse(Console.ReadLine());

        Console.Write("Taxa: ");
        decimal percentual = decimal.Parse(Console.ReadLine());

        Console.Write("Período (Meses): ");
        int tempo = int.Parse(Console.ReadLine());

        decimal taxa = percentual / 100;

        double anual = tempo / 12;

        double saldo = capitalInicial;

        int[] meses = new int[tempo];

        for (int i = 1; i <= meses.Length; i++)
        {
            
            double montanteFinal = calcularJuros(capitalInicial, taxa, i);
            double liquido = montanteFinal - capitalInicial;
            saldo = saldo + liquido;
            double rendimento = capitalInicial + liquido;

            Console.WriteLine($"| Valor Inicial: {capitalInicial}    | Taxa de Juros: {percentual:F2} %   | Rendimento: {rendimento:F2}       | Líquido: {liquido:F2}      |  Mês: {i} | Renda Acumulada: {saldo:F2} ");

        }

    }

    static double calcularJuros(double valorPresente, decimal taxaJuros, int periodo)
    {
        return valorPresente * Math.Pow(1 + (double)taxaJuros, periodo);
    }
}