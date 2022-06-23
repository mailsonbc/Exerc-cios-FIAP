using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Models
{
    class Veiculo
    {
        public string Cor { get; set; }
        public string Motor { get; set; }
        public int Ano { get; set; }
        public Fabricante Fabricante { get; set; }

        public Veiculo(string cor, string motor, int ano)
        {
            Cor = cor;
            Motor = motor;
            Ano = ano;
        }

        public Veiculo()
        {

        }

        public virtual void Acelerar()
        {
            Console.WriteLine($"Veículo acelerando...");
        }

        public void Acelerar(double aceleracao)
        {
            Console.WriteLine($"Veículo acelerando a {aceleracao} km/h");
        }

        public double Acelerar(bool turbo, double velocidade)
        {
            var velocidadeFinal = turbo ? velocidade * 10 : velocidade;
            Console.WriteLine($"Veículo acelerando a {velocidadeFinal}, possui turbo: {turbo}");
            return velocidadeFinal;
        }

        public virtual void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            var velocidadeFinal = !parado ? velocidadeAtual - velocidadeFrenagem : 0;
            Console.WriteLine($"Velocidade atual: {velocidadeFinal}");
        }
        public override string ToString()
        {
            return $"Cor: {Cor}\nMotor: {Motor} \nAno: {Ano} \nFabricante: {Fabricante}";
        }

    }
}
