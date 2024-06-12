# Lab 1 - Working with basic data types

1. Creating a new project named with Laboratorio1
```bash
dotnet new console -o "Laboratorio1"
```

2. Exercises
    - Write some variables with ***float, double, and decimal***
    - Do operations <sub>Search in the documentation</sub>with the class **String**
    - Do the same with **DateTime**
    - Explicit <sub>write the test</sub>convertions
        ```
        int i = 10; 
        float f = 0; 
        f = i; //conversão implícita, sem perda de dados. 
        System.Console.WriteLine(f); 
        f = 0.5F; 
        i = (int) f; //conversão explícita, com perda de dados. 
        System.Console.WriteLine(i);
        ```