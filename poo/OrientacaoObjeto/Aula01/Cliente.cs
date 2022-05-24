using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Cliente
    {
        private string? _nome;
        private int _idade;

        public string? Nome
        {
            get { return _nome; }
            set { _nome = value; }            
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if(value > 0)
                {
                    _idade = value;
                }
            }
        }

        public Endereco? Endereco { get; set; }
        public bool Especial { get; set; }
        public float Altura { get; set; }
    }
}
