using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Contar el número de vocales en una cadena");
        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine().ToLower();

        int contadorVocales = 0;
        for (int i = 0; i < cadena.Length; i++)
        {
            char caracter = cadena[i];
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contadorVocales++;
            }
        }
        Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);

        Console.WriteLine("\nEjercicio 2: Calcular la suma de los primeros 10 números pares");
        int sumaPares = 0;
        for (int numero = 2; numero <= 20; numero += 2)
        {
            sumaPares += numero;
        }
        Console.WriteLine("La suma de los primeros 10 números pares es: " + sumaPares);
    }
}
