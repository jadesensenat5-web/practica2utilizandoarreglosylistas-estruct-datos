// 1. programa que solicite al usuario un número y cuente cuántos números pares hay entre 1 y ese número utilizando FOR.

Console.Write("Número: ");
int n = int.Parse(Console.ReadLine()), c = 0;
for (int i = 1; i <= n; i++)
    if (i % 2 == 0) c++;
Console.WriteLine("Pares: " + c);
