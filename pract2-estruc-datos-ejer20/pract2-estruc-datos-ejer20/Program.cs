// 20. Buscar posición (Índice) de un elemento
int[] lista = { 5, 8, 12, 20 };
Console.Write("Número a buscar: ");
int buscar = int.Parse(Console.ReadLine());
int posicion = -1;
for (int i = 0; i < lista.Length; i++)
{
    if (lista[i] == buscar)
    {
        posicion = i;
        break;
    }
}
Console.WriteLine(posicion != -1 ? "Posición: " + posicion : "No encontrado");