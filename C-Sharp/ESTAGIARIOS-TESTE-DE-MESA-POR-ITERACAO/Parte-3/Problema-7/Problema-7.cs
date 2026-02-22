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

        // 🔹 Criando o objeto
        ContaInvestimento conta = new ContaInvestimento(capital, taxa);

        // 🔹 Simulação
        for (int i = 0; i < meses; i++)
        {
            double rendimento = conta.AplicarJuros();

            Console.WriteLine($"\nMês {i + 1}");
            Console.WriteLine($"Rendimento: {rendimento:F2}");
            Console.WriteLine($"Saldo: {conta.Saldo:F2}");

            Console.Write("\nDeseja resgatar? ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sim")
            {
                Console.Write("Valor: ");
                double valor = double.Parse(Console.ReadLine());

                if (!conta.Resgatar(valor))
                    Console.WriteLine("Saldo insuficiente!");
                else
                    Console.WriteLine($"Novo saldo: {conta.Saldo:F2}");
            }
        }

        Console.WriteLine("\nPrograma encerrado.");
    }
}