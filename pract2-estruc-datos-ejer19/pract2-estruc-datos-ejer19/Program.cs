//19. Comprobar si un valor está presente

int[] lista = { 10, 20, 30, 40 };
Console.Write("Buscar número: ");
int buscar = int.Parse(Console.ReadLine());
bool existe = false;
foreach (int n in lista) if (n == buscar) existe = true;
Console.WriteLine(existe ? "Si está" : "No está");