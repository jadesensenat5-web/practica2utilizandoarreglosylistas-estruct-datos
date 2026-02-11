// 9 y 10. Palabra Palíndroma

Console.Write("Palabra: ");
string palabra = Console.ReadLine().ToLower();
string reverso = "";
for (int i = palabra.Length - 1; i >= 0; i--) reverso += palabra[i];
Console.WriteLine(palabra == reverso ? "Es palíndroma" : "No es palíndroma");