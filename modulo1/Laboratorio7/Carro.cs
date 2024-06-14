using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio7.interf;

namespace Laboratorio7
{
    public class Carro : IEstadoBinario
    {
        public string Modelo { get; set; }
        public double Aceleracao { get; set; }

        private Stopwatch sw = new Stopwatch();


        public Carro(string modelo, double aceleracao) {
            this.Modelo = modelo;
            this.Aceleracao = aceleracao;
        }

        public void Ligar() {
            System.Console.WriteLine("Acelerando carro: " + this.Modelo);
            sw.Start();
            for (double i = 1 ; i <= 300 ; i = i + (i*this.Aceleracao)) {
                System.Console.WriteLine($"Vel atual: {i}");
            }
            Desligar();
        }

        public void Desligar()
        {
            sw.Stop();
            System.Console.WriteLine($"Carro: {this.Modelo} atingiu 300km/h no tempo de: {sw.ElapsedMilliseconds} ms");
        }
    }
}