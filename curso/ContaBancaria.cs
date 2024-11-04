using System;
using System.Reflection.Metadata.Ecma335;

public class ContaBancaria
{
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }

    public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
    {
        Deposito(depositoInicial);
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        Saldo -= quantia + 5.00;
    }

    public override string ToString()
    {
        return string.Format("Nome: {0}, Conta: {1}, Saldo: {2}", Titular, Numero, Saldo);
    }
}
