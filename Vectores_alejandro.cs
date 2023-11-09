using System;
using System.Linq;

class Program {
    static void Main() {
        // 1. Declarar un vector de números enteros y mostrar su contenido en la consola.
        int[] vectorEnteros = { 10, 5, 8, 2, 7 };
        Console.WriteLine("Contenido del vector:");
        foreach (int numero in vectorEnteros) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // 2. Calcular la suma de todos los elementos en un vector de números reales.
        double[] vectorReales = { 1.5, 2.7, 3.2, 4.8, 5.1 };
        double suma = 0;
        foreach (double numero in vectorReales) {
            suma += numero;
        }
        Console.WriteLine("La suma de los elementos es: " + suma);

        // 3. Encontrar el elemento más grande y el más pequeño en un vector de números enteros.
        int[] vectorNumeros = { 15, 7, 23, 4, 10 };
        int maximo = vectorNumeros.Max();
        int minimo = vectorNumeros.Min();
        Console.WriteLine("El elemento más grande es: " + maximo);
        Console.WriteLine("El elemento más pequeño es: " + minimo);

        // 4. Ordenar un vector de cadenas alfabéticamente.
        string[] vectorCadenas = { "Manzana", "Banana", "Naranja", "Pera" };
        Array.Sort(vectorCadenas);
        Console.WriteLine("Vector de cadenas ordenado:");
        foreach (string fruta in vectorCadenas) {
            Console.Write(fruta + " ");
        }
        Console.WriteLine();
    }
}
//Importaciones (using): Se importa el espacio de nombres System y System.Linq para utilizar funcionalidades de la biblioteca estándar y operaciones de LINQ (Language Integrated Query).

//Declaración de la Clase y Método Principal: La clase se llama Program y contiene el método Main, que es el punto de entrada del programa.

//Vectores:

//Se declara un vector de enteros vectorEnteros y se imprime su contenido.
//Se calcula la suma de un vector de números reales.
//Se encuentra el máximo y el mínimo en un vector de números enteros.
//Se ordena alfabéticamente un vector de cadenas.
