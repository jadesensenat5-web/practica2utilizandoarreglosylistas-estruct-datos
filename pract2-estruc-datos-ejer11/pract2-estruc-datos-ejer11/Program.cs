// 11 y 12. Oración Palíndroma

Console.Write("Oración: ");
string original = Console.ReadLine().ToLower().Replace(" ", "");
string reverso = "";
for (int i = original.Length - 1; i >= 0; i--) reverso += original[i];
Console.WriteLine(original == reverso ? "Es palíndroma" : "No es palíndroma");