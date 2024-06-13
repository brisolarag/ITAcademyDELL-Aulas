using Laboratorio4.src.Models.Contas.Simples;
using Laboratorio4.src.Models.Contas.Corrente;
using Laboratorio4.src.Models.Contas;
namespace Laboratorio4.Test;

public class UnitTest1
{
    [Fact]
    public void InstanciandoContaSimples() {
        ContaSimples conta = new("Osvaldo Pereira");
    }

    [Fact]
    public void InstanciandoContaCorrente() {
        ContaCorrente conta = new ContaCorrente("Osvaldo Pereira");
    }

    [Fact]
    public void TesteContaCorrente() {
        ContaCorrente d = new ContaCorrente("Osvaldo Pereira");
        Assert.False(d.SetLis(1000));
        d.Depositar(1000);
        Assert.True(d.SetLis(1000));
    }


    [Theory]
    [InlineData(500)]
    public void TesteDeposito(double n) {
        ContaCorrente c = new ContaCorrente("Osvaldo Pereira");
        c.Depositar(n);
        c.Depositar(n);
        c.Depositar(n);
        c.Depositar(n);
        c.Depositar(n);
        Assert.Equal(2500, c.Saldo);
    }
}