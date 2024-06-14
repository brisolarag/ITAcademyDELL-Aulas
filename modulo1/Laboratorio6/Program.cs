using Laboratorio6.Contas;

namespace Laboratorio6;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Clear();
        List<Conta> contas = new();
        ContaCorporativa conta1 = new ContaCorporativa("EmpresaTeste1");
        conta1.depositar(3000);
        conta1.sacar(500);
        contas.Add(conta1);

        ContaCorporativa conta2 = new ContaCorporativa("EmpresaTeste2");
        conta2.depositar(10000);
        conta2.depositar(543);
        contas.Add(conta2);

        ContaCorporativa conta3 = new ContaCorporativa("EmpresaTeste3");
        conta3.depositar(412344);
        conta3.sacar(234);
        contas.Add(conta3);

        ContaInvestimento conta4 = new ContaInvestimento();
        conta4.depositar(42343.44);
        conta4.sacar(323.33);
        conta4.investir(2131);
        contas.Add(conta4);

        foreach (var conta in contas) System.Console.WriteLine(conta);

    }
}
