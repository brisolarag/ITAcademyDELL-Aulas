// Exercicios: 
System.Console.Clear();
#region Exercicio 1
double exr1Teste = 1.04;
int exr1Teste2 = 1;
double exr1Teste3 = exr1Teste + exr1Teste2;
System.Console.WriteLine($"1. {exr1Teste3}");
#endregion


#region Exercicio2
string testeExercicio2 = "Testando";
System.Console.WriteLine($"2. {testeExercicio2} tem a letra T ? : {testeExercicio2.Contains('T')}");
#endregion

#region Exercicio3
DateTime testeExercicio3 = DateTime.Now;
DateTime testeExercicio3Mais10Dias = testeExercicio3.AddDays(10);
System.Console.WriteLine($"3. Adicionado 10 dias a data de hoje ({testeExercicio3}): Resposta = {testeExercicio3Mais10Dias}");
#endregion


