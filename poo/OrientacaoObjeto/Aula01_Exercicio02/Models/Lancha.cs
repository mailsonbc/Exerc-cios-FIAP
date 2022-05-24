
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_Exercicio02.Models
{
    internal class Lancha
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public decimal Peso { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeMotores { get; set; }
    }
}
