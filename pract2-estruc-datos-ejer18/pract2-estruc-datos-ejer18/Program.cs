// 18. Eliminar duplicados
int[] lista = { 1, 2, 2, 3, 4, 4, 5 };
int[] sinDuplicados = lista.Distinct().ToArray(); // Usa System.Linq
Console.WriteLine("Sin duplicados: " + string.Join(", ", sinDuplicados));