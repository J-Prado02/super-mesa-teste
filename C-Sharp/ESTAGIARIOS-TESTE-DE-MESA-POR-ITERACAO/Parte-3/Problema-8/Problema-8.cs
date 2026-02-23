using System;

class Program
{
    static void Main()
    {
        Console.Write("Valor Inicial: ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Taxa (% ao mês): ");
        decimal taxa = decimal.Parse(Console.ReadLine());

        Console.Write("Período (meses): ");
        int meses = int.Parse(Console.ReadLine());

        ContaInvestimento conta = new ContaInvestimento(capital, taxa);
        double rendimentoLiquidoAcumulado = 0;

        Console.WriteLine("\n---------------------------------------------------------------------------------");
        Console.WriteLine($"| {"Mês",-5} | {"Rendimento",-12} | {"Rend. Líquido",-14} | {"Resgate",-12} | {"Saldo",-12} |");
        Console.WriteLine("---------------------------------------------------------------------------------");

        for (int i = 0; i < meses; i++) 
        {
            double rendimento = conta.AplicarJuros();
            rendimentoLiquidoAcumulado += rendimento; 

            double valorResgate = 0;

            Console.Write($"\nDeseja resgatar no mês {i + 1}? ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("Valor: ");
                valorResgate = double.Parse(Console.ReadLine());

                if (!conta.Resgatar(valorResgate))
                {
                    Console.WriteLine("Saldo insuficiente! Nenhum valor retirado.");
                    valorResgate = 0;
                }
            }

            Console.WriteLine(
                $"| {i + 1,-5} | {rendimento,-12:F2} | {rendimentoLiquidoAcumulado,-14:F2} | {valorResgate,-12:F2} | {conta.Saldo,-12:F2} |"
            );
        }

        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine("\nPrograma encerrado.");
    }
}