using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Laboratorio4.src.Models.Operacoes;

namespace Laboratorio4.src.Models.Contas
{
    public abstract class ContaAbstrata : IConta
    {
        private static uint _id = 0;
        public uint Id { get; set; }
        public DateTime DataAbertura { get; protected set; }
        public double Saldo { get; protected set; }
        public string Titular { get; protected set; }
        protected List<Operacao> listaDeOperacoes;
        public double SaldoMedio { get; protected set; }

        public ContaAbstrata(string nome) {
            updateId();
            this.Titular = nome;
            this.Saldo = 0;
            DataAbertura = DateTime.Now;
            this.listaDeOperacoes = new();
            this.SaldoMedio = 0;
        }
        public abstract bool Depositar(double val);
        public abstract bool Sacar(double val);
        public string Extrato() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Conta: {this.Id}\n");
            builder.Append($"Titular: {this.Titular}\n");
            builder.Append($"Saldo: R$ {this.Saldo}\n");
            builder.Append($"SaldoMedio: R$ {this.SaldoMedio}\n");
            builder.Append("--- Extrato ---\n");
            foreach (var op in listaDeOperacoes) builder.Append($"{op.ToString()}\n");
            return builder.ToString();
        }

        private void updateId() {
            this.Id = _id;
            _id++;
        }







    }
}