using System;
using Aula02_Bank.Exceptions;
using Aula02_Bank.Interfaces;

namespace Aula02_Bank.Models
{
    class ContaCorrente : Conta, IAcoesDaConta
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }

        public string Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor de depósito inválido.");
            }
            Saldo += valor;
            return $"Valor depositado de {valor}. Saldo total: {Saldo}";
        }
    }
}
