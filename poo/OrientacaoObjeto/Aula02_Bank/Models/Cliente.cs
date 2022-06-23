using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_Bank.Models
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
