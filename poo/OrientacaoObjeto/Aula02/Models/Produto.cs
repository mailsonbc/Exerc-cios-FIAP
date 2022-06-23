using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Models
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int ItensEmEstoque { get; set; }
        public string Marca { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($" Nome: {Nome}\n Preço: {Preco}\n Itens em estoque: {ItensEmEstoque}\n Marca: {Marca}");
        }

        public double CalcularDesconto(double valorDesconto)
        {
            double valorFinal = Preco - valorDesconto;
            return valorFinal;
        }
    }
}
