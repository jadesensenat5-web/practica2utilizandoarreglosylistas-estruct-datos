// 7. Múltiplos de 5 entre dos números

Console.Write("A: "); int a = int.Parse(Console.ReadLine());
Console.Write("B: "); int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
    if (i % 5 == 0) Console.WriteLine(i);