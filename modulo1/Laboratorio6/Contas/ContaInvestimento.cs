using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6.Contas
{
    public class ContaInvestimento : Conta
    {
        private const double TAXA_LUCRO = 1.1;
        public double Aplicado { get; private set; }

        public ContaInvestimento() : base() {
            this.Aplicado = 0;
        }

        public override bool depositar(double val) {
            if (val < 0) return false;
            this.Saldo += val;
            return true;
        }

        public override bool sacar(double val) {
            if ((val < 0) || (val > this.Saldo)) return false;
            this.Saldo -= val;
            return true;
        }

        public bool investir(double val) {
            if (val < 0) return false;
            this.Aplicado += val * TAXA_LUCRO;
            return true;
        }

        public override string ToString () {
            StringBuilder builder = new StringBuilder(base.ToString());

            builder.Append("\nAplicado: ");
            builder.Append(this.Aplicado);
            return builder.ToString();
        }
    }
}