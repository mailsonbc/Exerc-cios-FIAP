using System;
using Aula01_Exercicio02.Models;

namespace Aula01_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da cor: ");
            string nomeCor = Console.ReadLine();

            Console.WriteLine("Digite o R da cor com valores de 0 a 255: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G da cor com valores de 0 a 255: ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B da cor com valores de 0 a 255: ");
            int b = int.Parse(Console.ReadLine());

            Cor cor = new Cor();

            cor.Nome = nomeCor;
            cor.R = r;
            cor.G = g;
            cor.B = b;

            Console.WriteLine("Digite a marca do carro: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o ano de fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite o fabricante do carro: ");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro: ");
            string corCarro = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite valor do carro: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite se tem ar-condicionado (true/false)");
            bool arCondicionado = bool.Parse(Console.ReadLine());

            Console.WriteLine("O carro é automático? (true/false)");
            bool automatico = bool.Parse(Console.ReadLine());

            Console.WriteLine("É usado? (true/force)");
            bool usado = bool.Parse(Console.ReadLine());

            Carro carro = new Carro();

            carro.Marca = marca;
            carro.Placa = placa;
            carro.Usado = usado;
            carro.AnoFabricacao = anoFabricacao;
            carro.Fabricante = fabricante;
            carro.ArCondicionado = arCondicionado;
            carro.Automatico = automatico;
            //carro.Cor = corCarro; //errado
            carro.Modelo = modelo;  
            carro.Valor = valor;

        }
    }
}
