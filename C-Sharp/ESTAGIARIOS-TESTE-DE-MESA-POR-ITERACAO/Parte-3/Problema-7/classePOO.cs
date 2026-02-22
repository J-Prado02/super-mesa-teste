using System;
using System.Diagnostics.Contracts;

class ContaInvestimento
{
    public double Saldo { get; private set; }
    public decimal Taxa { get; private set; }

    public ContaInvestimento(double capitalInicial, decimal taxa)
    {
        Saldo = capitalInicial;
        Taxa = taxa / 100;
    }

    public double AplicarJuros()
    {
        double rendimento = Saldo * (double)Taxa;
        Saldo += rendimento;
        return rendimento;
    }

    public bool Resgatar(double valor)
    {
        if (valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }
}