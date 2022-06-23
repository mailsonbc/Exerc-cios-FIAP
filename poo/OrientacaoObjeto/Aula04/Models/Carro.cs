using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Models
{
    class Carro : Veiculo
    {
        public bool ArCondicionado { get; set; }
        public int QuantidadePortas { get; set; }

        public Carro(string cor, string motor, int ano, bool arCondicionado, int quantidadePortas) : base(cor, motor, ano)
        {
            ArCondicionado = arCondicionado;
            QuantidadePortas = quantidadePortas;
        }

        public Carro()
        {

        }

        public Carro(int quantidade)
        {
            QuantidadePortas = quantidade;
        }

        public override void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            var velocidadeFenagemCarro = velocidadeFrenagem * 0.8;
            Console.WriteLine($"Nova velocidade de frenagem {velocidadeFenagemCarro}");
            base.Frear(velocidadeAtual, parado, velocidadeFrenagem);
        }

        public override string ToString()
        {
            return base.ToString() + $", \nAr-condicionado: {(ArCondicionado ? "Tem" : "Não tem")} \nNúmero de portas: {QuantidadePortas}";
        }
    }
}
