using System;

namespace Aula01
{
    class Program
    {
        public static void Main(string[] _0)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Maílson";
            cliente.Idade = 33;
            cliente.Altura = 1.75f;
            cliente.Especial = false;

            Console.WriteLine($"Idade: {cliente.Idade}");

            Endereco endereco = new Endereco();

            endereco.Logradouro = "Rua Dois";
            endereco.Numero = "100";
            endereco.Cep = "11088-330";
            endereco.Cidade = "Santos";


            cliente.Endereco = endereco;

            Console.WriteLine($"Endereço: {cliente.Endereco.Logradouro}");
        }
    }
}