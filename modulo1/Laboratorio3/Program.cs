System.Console.Clear();
#region Exercicio 1
Dictionary<string,string> paisesDDI = new ();
paisesDDI["Brasil"] = "+55";
paisesDDI["Islandia"] = "+354";
paisesDDI["Estados Unidos"] = "+1";
System.Console.WriteLine($"DDI (Brasil): {paisesDDI["Brasil"]}");
System.Console.WriteLine($"DDI (Islandia): {paisesDDI["Islandia"]}");
System.Console.WriteLine($"DDI (Estados Unidos): {paisesDDI["Estados Unidos"]}");
#endregion

#region Exercicio 2 e 3
List<int> numerosReais = new();
Random rnd = new();
for (int i = 0; i < 16 ; i++) numerosReais.Add(rnd.Next(1,100));

System.Console.WriteLine("Numeros da lista: ");
foreach (int i in numerosReais) System.Console.Write($"{i} ");
System.Console.WriteLine();



static int SomaNumeros (List<int> listaNumeros) {
    int somaAtual = 0;
    foreach (int n in listaNumeros) somaAtual += n;
    return somaAtual;
}

static double MediaLista (List<int> lista) {
    int soma = SomaNumeros(lista);
    double media = soma/lista.Count;
    return media;
}

static int TotalAcimaMedia(List<int> listaNumeros) {
    double media = MediaLista(listaNumeros);

    int acc = 0;
    foreach(int i in listaNumeros) {
        if (i > media) acc++; 
    }
    return acc;
}

static List<int> ListaAcimaMedia (List<int> lista) {
    double media = MediaLista(lista);

    List<int> numsAcima = new();
    foreach (int i in lista) {
        if (i > media)
            numsAcima.Add(i);
    }
    return numsAcima;

}


System.Console.WriteLine($"Media: {MediaLista(numerosReais)}");
System.Console.WriteLine($"Numeros Acima: {TotalAcimaMedia(numerosReais)}");
System.Console.WriteLine("Todos Numeros Acima: ");
List<int> numAcimaMedia = ListaAcimaMedia(numerosReais);
foreach (int i in numAcimaMedia) System.Console.Write($"{i} ");

#endregion


