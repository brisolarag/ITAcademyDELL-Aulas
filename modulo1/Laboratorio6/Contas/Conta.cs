using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6.Contas
{
    public abstract class Conta
    {
        private uint _id;
        public uint Id { get; set; }
        public double Saldo { get; protected set; }

        public Conta() {
            updateId();
            this.Saldo = 0;
        }

        public abstract bool depositar(double val);
        public abstract bool sacar(double val);

        private void updateId() {
            this.Id = _id;
            _id++;
        }


        public override string ToString () {
            StringBuilder builder = new();
            builder.Append("Conta: ");
            builder.Append(this.Id);
            builder.Append(" | Saldo: ");
            builder.Append(this.Saldo);
            return builder.ToString();
        }
    }
}