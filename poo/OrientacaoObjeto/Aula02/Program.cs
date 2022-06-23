using System;
using Aula02.Models;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto em estoque: ");
            int itensEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a marca do produto: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Se houver desconto, informe: ");
            double desconto = double.Parse(Console.ReadLine()); 

            produto.Nome = nome;
            produto.Preco = preco;
            produto.ItensEmEstoque = itensEmEstoque;
            produto.Marca = marca;

            produto.Preco = produto.CalcularDesconto(desconto);
            produto.ExibirDados();
            /////////////////////////////////////////////////////////////////////////
            




        }
    }
}
