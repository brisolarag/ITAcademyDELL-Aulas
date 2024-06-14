using Laboratorio5.Circulos;

namespace Laboratorio5;

class Program
{
    static void Main(string[] args)
    {
        Circulo circ1 = new Circulo(); 
        // Console.WriteLine($"circ1: {circ1}"); 
        Circulo circ2 = new Circulo(2.4, 5, 3); 
        // Console.WriteLine($"circ2: {circ2}"); 
        CirculoColorido circ3 = new CirculoColorido(); 
        // Console.WriteLine($"circ3: {circ3}"); 
        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho"); 
        // Console.WriteLine($"circ4: {circ4}");
        Circulo circ5 = new CirculoColorido(2.4, 5, 3, "azul"); 
        // System.Console.WriteLine($"circ5: {circ5}");
        CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(Cor.amarelo);
        // System.Console.WriteLine($"circ6: {circ6}");

        BaseDeCirculos baseDeCirculos = new BaseDeCirculos();
        baseDeCirculos.Circulos.Add(circ1);
        baseDeCirculos.Circulos.Add(circ2);
        baseDeCirculos.Circulos.Add(circ3);
        baseDeCirculos.Circulos.Add(circ4);
        baseDeCirculos.Circulos.Add(circ5);
        baseDeCirculos.Circulos.Add(circ6);
        System.Console.WriteLine(baseDeCirculos.ImprimirCirculos());


        
    }
}
