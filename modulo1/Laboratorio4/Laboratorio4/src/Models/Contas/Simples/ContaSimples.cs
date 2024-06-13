using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio4.src.Models.Contas;
using Laboratorio4.src.Models.Operacoes;

namespace Laboratorio4.src.Models.Contas.Simples
{
    public class ContaSimples : ContaAbstrata
    {
        protected double _acumulador = 0;

        public ContaSimples(string nome) : base(nome) { }

        public override bool Sacar(double val) {
            if ((val > this.Saldo) || (val < 0))
                return false;
            listaDeOperacoes.Add(new Operacao(TipoOperacao.saque, val));
            Saldo -= val;
            updateSaldoMedio();
            return true;
        }

        public override bool Depositar(double val) {
            if (val < 0) return false;
            listaDeOperacoes.Add(new Operacao(TipoOperacao.deposito, val));
            this.Saldo += val;
            updateSaldoMedio();
            return true;
        }

        protected void updateSaldoMedio() {
            this._acumulador += this.Saldo;
            this.SaldoMedio = _acumulador / listaDeOperacoes.Count;
        }
    }
}