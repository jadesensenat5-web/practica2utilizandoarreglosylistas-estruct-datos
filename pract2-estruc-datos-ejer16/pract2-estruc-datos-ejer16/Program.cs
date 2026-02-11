// 16. Nueva lista multiplicada por 2

int[] original = { 1, 2, 3, 4 };
int[] nueva = new int[original.Length];
for (int i = 0; i < original.Length; i++)
{
    nueva[i] = original[i] * 2;
    Console.WriteLine(nueva[i]);
}