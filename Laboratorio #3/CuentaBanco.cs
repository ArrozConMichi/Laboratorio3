using System.Collections.Generic;
using System;

internal class CuentaBanco
{
    public string nCliente { get; set; }
    public decimal Balance { get; private set; }
    public List<decimal> Retiros { get; private set; }
    public List<decimal> Depositos { get; private set; }

    public CuentaBanco(string nomCliente, decimal balanceInicial)
    {
        nCliente = nomCliente;
        Balance = balanceInicial;
        Retiros = new List<decimal>();
        Depositos = new List<decimal>();
    }

    public void Deposito(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Balance += cantidad;
            Depositos.Add(cantidad);
        }
        else
        {
            throw new ArgumentException("El monto del depósito debe ser positivo.");
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= Balance && amount > 0)
        {
            Balance -= amount;
            Retiros.Add(amount);
            return true;
        }
        return false;
    }

    public string GetFormattedBalance()
    {
        return Balance.ToString("C"); // "C" formatea el número como moneda
    }
}
