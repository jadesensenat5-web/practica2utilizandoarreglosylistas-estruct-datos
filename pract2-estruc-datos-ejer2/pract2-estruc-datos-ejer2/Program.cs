//2. Número Perfecto

Console.Write("Pon el número: ");
int n = int.Parse(Console.ReadLine()), s = 0, i = 1;
while (i < n)
{
    if (n % i == 0) s += i;
    i++;
}
Console.WriteLine(s == n ? "Es perfecto" : "No es perfecto");
