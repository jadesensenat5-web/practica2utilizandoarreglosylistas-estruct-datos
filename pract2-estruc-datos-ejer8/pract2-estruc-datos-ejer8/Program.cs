// 8. Positivos, Negativos o Ceros

int p = 0, n = 0, z = 0;
for (int i = 1; i <= 10; i++)
{
    double x = double.Parse(Console.ReadLine());
    if (x > 0) p++; else if (x < 0) n++; else z++;
}
Console.WriteLine($"Pos: {p}, Neg: {n}, Ceros: {z}");