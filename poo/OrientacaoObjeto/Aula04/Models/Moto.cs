using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Models
{
    class Moto : Veiculo
    {
        public bool PartidaEletrica { get; set; }
        public Moto(string cor, string motor, int ano, bool partida) : base(cor, motor, ano)
        {
            PartidaEletrica = partida;
        }

        public Moto()
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine($"Moto acelerando...");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPartida elétrica: {(PartidaEletrica ? "Sim" : "Não")}";
        }
    }
}
