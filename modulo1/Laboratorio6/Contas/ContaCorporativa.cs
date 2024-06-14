using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6.Contas
{
    public class ContaCorporativa : Conta
    {
        private const double TAXA_DEPOSITO = 0.4;
        private const double TAXA_SAQUE = 0.7;
        public string NomeEmpresa { get; set; }    

        public ContaCorporativa (string nomeEmpresa) : base () {
            this.NomeEmpresa = nomeEmpresa;
        }

        public override bool depositar(double val) {
            if (val < 100) return false;
            this.Saldo += val - (val * TAXA_DEPOSITO);
            return true;
        }

        public override bool sacar (double val) {
            if ((val < 1000) || (val > this.Saldo)) return false;
            this.Saldo -= val - (val * TAXA_SAQUE);
            return true;
        }


        public override string ToString () {
            StringBuilder builder = new StringBuilder(base.ToString());

            builder.Append("\nNome da Empresa: ");
            builder.Append(this.NomeEmpresa);
            return builder.ToString();
        }
    }
}