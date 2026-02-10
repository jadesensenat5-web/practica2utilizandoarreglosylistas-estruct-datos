// 5. El mayor de 10 números
double mayor = -999999;
for (int i = 1; i <= 10; i++)
{
    Console.Write("Número: ");
    double n = double.Parse(Console.ReadLine());
    if (n > mayor) mayor = n;
}
Console.WriteLine("El mayor es: " + mayor);
