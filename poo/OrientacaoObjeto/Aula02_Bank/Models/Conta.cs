using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Bank.Models
{
    abstract class Conta
    {
        public string numeroConta { get; set; }
        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
    }
}
