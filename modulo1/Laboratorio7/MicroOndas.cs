using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio7.interf;

namespace Laboratorio7
{
    public class MicroOndas : IEstadoBinario
    {
        public string Modelo { get; set; }
        public string Comida { get; set; }

        public MicroOndas(string modelo) {
            this.Comida = String.Empty;
            this.Modelo = modelo;
        }

        public void ColocarComida (string comida) {
            this.Comida = comida;
        }

        public void RetirarComida () {
            this.Comida = String.Empty;
        }

        public void Ligar() {
            if (this.Comida == String.Empty) {
                System.Console.WriteLine("Não tem comida no microondas...");
            } else {
                System.Console.WriteLine($"A comida: {this.Comida} começou esquentar...");
            }
        }

        public void Desligar() {
            System.Console.WriteLine($"A comida: {this.Comida} agora esta quente");
        }
    }
}