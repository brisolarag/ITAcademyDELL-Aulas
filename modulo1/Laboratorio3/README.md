# Laboratorio 3
```csharp
Dictionary<int, string> paises = new Dictionary<int, string>(); 
paises[44] = "Reino Unido"; 
paises[33] = "França"; 
paises[55] = "Brasil"; 
Console.WriteLine("O código 55 é: {0}", paises[55]); 
foreach (var item in paises) 
{ 
                int codigo = item.Key; 
                string pais = item.Value; 
                Console.WriteLine("Código {0} = {1}", codigo, pais); 
} 

```