// Exercicios

#region Exercicio1
Random rnd = new();

int[] primeiroArr_e1 = new int[5];
int[] segundoArr_e2 = new int[primeiroArr_e1.Length];
for (int i = 0 ; i < primeiroArr_e1.Length ; i ++) primeiroArr_e1[i] = rnd.Next(1,100);

Array.Copy(primeiroArr_e1, segundoArr_e2, primeiroArr_e1.Length);

System.Console.WriteLine("Fist array:");
foreach (var item in primeiroArr_e1) System.Console.WriteLine(item);
System.Console.WriteLine("Second array:");
foreach (var item in segundoArr_e2) System.Console.WriteLine(item);

#endregion