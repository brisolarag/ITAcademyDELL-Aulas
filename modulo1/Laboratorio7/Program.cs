namespace Laboratorio7;
class Program
{
    static void Main(string[] args)
    {
        Carro c = new("Fiat Punto", 0.01);
        c.Ligar();

        MicroOndas philips = new("Philips 3.0");
        philips.ColocarComida("Feijão");
        philips.Ligar();
        philips.Desligar();
    }
}
