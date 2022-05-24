using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Exercicio02.Models
{
    class Carro
    {
        public string Marca { get; set; }
        public int AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public Cor Cor { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public bool ArCondicionado { get; set; }
        public bool Automatico { get; set; }
        public bool Usado { get; set; }
    }
}
