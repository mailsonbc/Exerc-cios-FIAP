using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Exercicio02.Models
{
    class Aviao
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public Cor Cor { get; set; }
        public string Prefixo { get; set; }
        public double HorasVoo { get; set; }
    }
}
