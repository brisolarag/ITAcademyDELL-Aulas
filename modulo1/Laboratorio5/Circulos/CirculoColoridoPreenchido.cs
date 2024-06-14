using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Circulos
{
    public enum Cor { preto, azul, amarelo, verde, naoAtribuida };
    public class CirculoColoridoPreenchido : CirculoColorido
    {
        public Cor CorPreenchimento { get; set; }
        public CirculoColoridoPreenchido() : base() {
            this.CorPreenchimento = Circulos.Cor.naoAtribuida;
        }
        public CirculoColoridoPreenchido(Cor corPreenchimento) : base() {
            this.CorPreenchimento = corPreenchimento;
        }
        public CirculoColoridoPreenchido(double x, double y, double z, string c) : base(x,y,z,c) {
            this.CorPreenchimento = Circulos.Cor.naoAtribuida;
        }
        public CirculoColoridoPreenchido(double x, double y, double z, string c, Cor corPreenchimento) : base(x,y,z,c) {
            this.CorPreenchimento = corPreenchimento;
        }
        public override string ToString()
        {
            return base.ToString() + " cor preenchimento= " + this.CorPreenchimento;
        }

    }
}