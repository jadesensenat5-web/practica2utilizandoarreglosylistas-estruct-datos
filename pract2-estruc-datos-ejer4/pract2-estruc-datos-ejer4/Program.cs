// 4. Mínimo Común Múltiplo
Console.Write("A: "); int a = int.Parse(Console.ReadLine());
Console.Write("B: "); int b = int.Parse(Console.ReadLine());
int m = (a > b) ? a : b;
while (m % a != 0 || m % b != 0) m++;
Console.WriteLine("MCM: " + m);
