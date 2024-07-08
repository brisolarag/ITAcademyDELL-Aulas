# Convenções
### Toda propriedade de escrita publica com getter e setter vai ser mapeada
> add [NotMapped] para não mapear
</br>

### Propriedade é opicional se => **pode-se atribuir null para ela**
```csharp
public string? Nome {get; set;}
// nome = nullable
```
```csharp
public string Nome {get; set;}
// nome = not null
```
</br>

### Configuração de chave primária:
```csharp
internal class Algo {
    public string Id {get; set;}
    // chave primaria
}
```

```csharp
internal class Algo {
    public string AlgoId {get; set;}
    // chave primaria
}
```
</br>

### Cuidar com os construtores...
> The parameter types and names must match property types and names, except that properties can be Pascal-cased while the parameters are camel-cased.</br>
> EF Core cannot set navigation properties (such as Blog or Posts above) using a constructor.</br>
> The constructor can be public, private, or have any other accessibility. However, lazy-loading proxies require that the constructor is accessible from the inheriting proxy class. Usually this means making it either public or protected.</br>

