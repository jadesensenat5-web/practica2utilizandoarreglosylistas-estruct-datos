// 14. Valor Máximo y Mínimo

int[] lista = { 8, 3, 11, 2, 9 };
int max = lista[0], min = lista[0];
foreach (int n in lista)
{
    if (n > max) max = n;
    if (n < min) min = n;
}
Console.WriteLine($"Máximo: {max}, Mínimo: {min}");
