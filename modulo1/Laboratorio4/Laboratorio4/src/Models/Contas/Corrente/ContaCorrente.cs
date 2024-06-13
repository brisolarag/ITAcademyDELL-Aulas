using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio4.src.Models.Contas.Simples;
using Laboratorio4.src.Models.Operacoes;

namespace Laboratorio4.src.Models.Contas.Corrente
{
    public class ContaCorrente : ContaSimples
    {

        public double Lis { get; private set; }
        public ContaCorrente(double _lis, string nome) : base(nome) {
            this.Lis = _lis;
        }

        public ContaCorrente(string nome) : base(nome) {}

        public override bool Sacar(double val) {
            if ((val > this.Saldo + this.Lis) || (val < 0)) return false;
            listaDeOperacoes.Add(new Operacao(TipoOperacao.saque, val));
            this.Saldo -= val;
            updateSaldoMedio();
            return true;
        }

        public double VerificaCredito () {
            if (this.Saldo < 0) return this.Lis;
            return this.Lis+Saldo;
        }

        public bool SetLis(double val) {
            if (val > this.Saldo) return false;
            this.Lis = val;
            return true;
        }
    }
}