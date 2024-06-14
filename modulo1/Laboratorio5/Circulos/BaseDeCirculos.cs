using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5.Circulos
{
    public class BaseDeCirculos
    {
        public List<Circulo> Circulos { get; set; }
        public BaseDeCirculos() {
            this.Circulos = new List<Circulo>();
        }

        public string ImprimirCirculos() {
            StringBuilder builder = new();
            foreach (var c in this.Circulos) {
                builder.Append(c);
                builder.Append("\n");
            }
            return builder.ToString();
        }

    }
}