using System;

class Program
{
    //Con este programa, puedes generar y explorar la secuencia de Fibonacci. Aquí hay algunas acciones que puedes realizar:

//Generar la Secuencia de Fibonacci:

//Ingresa la cantidad de términos de la secuencia de Fibonacci que deseas generar cuando se te solicite.
//El programa utilizará la función recursiva ObtenerTerminoFibonacci para calcular y mostrar la secuencia de Fibonacci.
//Explorar Diferentes Cantidades de Términos:

//Experimenta ingresando diferentes cantidades de términos para observar cómo crece la secuencia de Fibonacci.
//Observa cómo la secuencia se forma sumando los dos términos anteriores.
//Salir del Programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite la cantidad de términos.
//El programa mostrará un mensaje de despedida y terminará.
//Manejar Entradas no Válidas:

//El programa maneja entradas no válidas, por ejemplo, si ingresas texto o números negativos.
//Si la entrada no es válida, te indicará que intentes nuevamente.
    static void Main()
    {
        Console.WriteLine("Generador de Secuencia Fibonacci");

        while (true)
        {
            Console.Write("Ingrese la cantidad de términos a generar (o '0' para salir): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            if (int.TryParse(input, out int cantidadTerminos) && cantidadTerminos >= 0)
            {
                // Generar y mostrar la secuencia de Fibonacci
                MostrarSecuenciaFibonacci(cantidadTerminos);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
    }

    // Función para generar y mostrar la secuencia de Fibonacci
    static void MostrarSecuenciaFibonacci(int n)
    {
        Console.WriteLine("\nSecuencia de Fibonacci:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(ObtenerTerminoFibonacci(i) + " ");
        }

        Console.WriteLine();
    }

    // Función recursiva para obtener el término de Fibonacci en la posición dada
    static int ObtenerTerminoFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return ObtenerTerminoFibonacci(n - 1) + ObtenerTerminoFibonacci(n - 2);
        }
    }
}
