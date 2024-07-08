# Anotações:


- CODE FIRST
- DATABASE FIRST

</br>

### Convenções
- Toda propriedade de escrita publica com getter e setter vai ser mapeada
>> add [NotMapped] para não mapear
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

