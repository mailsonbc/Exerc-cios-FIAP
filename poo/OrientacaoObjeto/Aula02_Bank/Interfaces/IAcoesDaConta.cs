using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Bank.Interfaces
{
    interface IAcoesDaConta
    {
        public void Sacar(double valor);
        public string Depositar(double valor);
    }
}
