using System;
using Aula04.Models;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante() { Nome = "Gurgel"};

            Carro carro = new Carro();
            carro.Fabricante = fabricante;
            carro.Motor = "4.8";
            carro.Cor = "Vermelho";
            carro.Ano = 2010;
            carro.ArCondicionado = true;
            carro.QuantidadePortas = 4;
            
        }
    }
}
