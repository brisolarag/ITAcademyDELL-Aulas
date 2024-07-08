# Anotações:


- CODE FIRST
- DATABASE FIRST

</br>

### Convenções
- Toda propriedade de escrita publica com getter e setter vai ser mapeada
> add [NotMapped] para não mapear
</br>

- Propriedade é opicional se => **pode-se atribuir null para ela**
```csharp
public string? Nome {get; set;}
// nome = nullable
```
```csharp
public string Nome {get; set;}
// nome = not null
```
</br>

- Configuração de chave primária:
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

