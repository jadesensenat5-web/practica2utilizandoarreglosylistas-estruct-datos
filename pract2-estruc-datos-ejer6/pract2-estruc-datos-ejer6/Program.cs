// 6. Contar Primos

int[] nums = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
int c = 0;
foreach (int n in nums)
{
    int div = 0;
    for (int i = 1; i <= n; i++) if (n % i == 0) div++;
    if (div == 2) c++;
}
Console.WriteLine("Primos: " + c);