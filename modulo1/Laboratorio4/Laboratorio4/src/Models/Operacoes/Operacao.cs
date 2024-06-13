using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio4.src.Models.Operacoes
{
    public enum TipoOperacao { saque, deposito };
    public class Operacao
    {
        private uint _operacaoId = 0;
        public uint OperacaoId { get; set; }
        public double Valor { get; set; }
        public DateTime MomentoDaOperacao { get; set; }
        public TipoOperacao Tipo { get; set; }

        public Operacao(TipoOperacao tipo, double valor) {
            updateId();
            this.Valor = valor;
            this.Tipo = tipo;
            this.MomentoDaOperacao = DateTime.Now;
        }
        
        private void updateId() {
            this.OperacaoId = _operacaoId;
            _operacaoId++;
        }

        public override string ToString() {
            return "Operação: [" + this.Tipo+"; "+this.Valor+"; "+this.MomentoDaOperacao.ToString()+"]";
        }
    }
}