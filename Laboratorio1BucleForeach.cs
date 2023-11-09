using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Imprimir cada carácter de una cadena en una línea separada");
        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine();
        foreach (char caracter in cadena)
        {
            Console.WriteLine(caracter);
        }

        Console.WriteLine("\nEjercicio 2: Calcular la suma de todos los elementos de una lista de números enteros");
        List<int> numeros = new List<int> { 5, 10, 15, 20, 25 };
        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }
        Console.WriteLine("La suma de los elementos de la lista es: " + suma);

        Console.WriteLine("\nEjercicio 3: Mostrar todos los números pares en una lista de números enteros");
        List<int> numerosPares = new List<int>();
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                numerosPares.Add(numero);
            }
        }
        Console.WriteLine("Números pares en la lista: " + string.Join(", ", numerosPares));

        Console.WriteLine("\nEjercicio 4: Contar el número de veces que aparece una letra específica en una cadena");
        Console.Write("Ingresa una letra: ");
        char letraBuscada = Console.ReadLine()[0];
        int contadorLetra = 0;
        foreach (char caracter in cadena)
        {
            if (caracter == letraBuscada)
            {
                contadorLetra++;
            }
        }
        Console.WriteLine("La letra '" + letraBuscada + "' aparece " + contadorLetra + " veces en la cadena.");

        Console.WriteLine("\nEjercicio 5: Calcular el promedio de una lista de calificaciones");
        List<double> calificaciones = new List<double> { 9.5, 8.0, 7.5, 9.0, 6.5 };
        double promedio = calificaciones.Average();
        Console.WriteLine("El promedio de las calificaciones es: " + promedio);

        Console.WriteLine("\nEjercicio 6: Invertir una cadena ingresada por el usuario");
        char[] caracteresInvertidos = cadena.ToCharArray();
        Array.Reverse(caracteresInvertidos);
        string cadenaInvertida = new string(caracteresInvertidos);
        Console.WriteLine("Cadena invertida: " + cadenaInvertida);

        Console.WriteLine("\nEjercicio 7: Imprimir todos los nombres de una lista de cadenas");
        List<string> nombres = new List<string> { "Ana", "Juan", "María", "Carlos" };
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        Console.WriteLine("\nEjercicio 8: Ordenar una lista de números enteros en orden ascendente");
        List<int> numerosDesordenados = new List<int> { 25, 10, 15, 5, 20 };
        numerosDesordenados.Sort();
        Console.WriteLine("Lista ordenada en orden ascendente: " + string.Join(", ", numerosDesordenados));

        Console.WriteLine("\nEjercicio 9: Encontrar y mostrar el elemento máximo y mínimo en una lista de números");
        int maximo = numeros.Max();
        int minimo = numeros.Min();
        Console.WriteLine("El elemento máximo en la lista es: " + maximo);
        Console.WriteLine("El elemento mínimo en la lista es: " + minimo);

        Console.WriteLine("\nEjercicio 10: Multiplicar todos los elementos de una lista de números enteros");
        List<int> numerosMultiplicacion = new List<int> { 2, 3, 4, 5 };
        int producto = 1;
        foreach (int numero in numerosMultiplicacion)
        {
            producto *= numero;
        }
        Console.WriteLine("El producto de los elementos de la lista es: " + producto);
    }
}
