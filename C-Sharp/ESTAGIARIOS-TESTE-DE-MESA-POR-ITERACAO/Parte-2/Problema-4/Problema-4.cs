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

        for (int i = 0; i < meses.Length; i++)
        {
            
            double liquido = saldo * (double)taxa;
            saldo = saldo + liquido;
            double rendimento = saldo;
            double[] mesesRendimento = new double[tempo];
            mesesRendimento[i] = saldo;


            Console.WriteLine($"\n | Valor Inicial: {capitalInicial}    | Taxa de Juros: {percentual:F2} %   | Rendimento: {rendimento:F2}       | Líquido: {liquido:F2}        |  Mês: {i + 1} | Renda Acumulada: {saldo:F2} ");

            Console.Write("\n Deseja resgatar algum Valor ? ");
            string resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                
                Console.Write(" Valor: ");
                double valorResgate = double.Parse(Console.ReadLine());

                if(valorResgate > saldo)
                {
                    Console.Write("\n Saldo Insufiiente \n");
                    Console.Write($"\n Saldo disponível: {saldo} \n");
                }
                else
                {
                    double saldoAnterior = saldo;
                     saldo = saldo - valorResgate;
                    capitalInicial = saldo;

                    Console.Write($"\n | Saldo Anterior: {saldoAnterior:F2} | Saldo Retirado: {valorResgate:F2} | Saldo Atual: {saldo:F2} | \n");
                }
                

            }

        }

        Console.Write("\n Programa Encerrado \n");

        

    }

}