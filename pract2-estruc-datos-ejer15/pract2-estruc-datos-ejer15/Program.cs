// 15. Promedio de una lista

int[] lista = { 10, 8, 7, 9 };
double suma = 0;
foreach (int n in lista) suma += n;
Console.WriteLine("Promedio: " + (suma / lista.Length));
