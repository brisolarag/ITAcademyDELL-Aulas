using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Circulos
{
    public class CirculoColorido : Circulo
    {
        public string Cor { get; set; }


        public CirculoColorido() {
            this.Cor = "preto";
        }

        public CirculoColorido(double x, double y, double r, string c) : base () {
            this.Cor = c;
        }

        public override string ToString()
        {
            return base.ToString() + " cor= " + this.Cor;
        }
    }
}