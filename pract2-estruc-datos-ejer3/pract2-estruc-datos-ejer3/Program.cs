// Media de 5 números

double s = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Num " + i + ": ");
    s += double.Parse(Console.ReadLine());
}
Console.WriteLine("Media: " + (s / 5));