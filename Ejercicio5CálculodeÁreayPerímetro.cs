using System;

class Program
{
    //Este algoritmo es un programa en C# que actúa como una calculadora para el área y el perímetro de diferentes figuras geométricas. Aquí hay un resumen de lo que hace:

//Menú de Opciones:

//Al ejecutar el programa, se presenta un menú con las siguientes opciones:
//Calcular Área y Perímetro de un Círculo
//Calcular Área y Perímetro de un Triángulo
//Calcular Área y Perímetro de un Rectángulo
//Salir
//Selección de Figura:

//El usuario puede seleccionar la figura geométrica para la cual desea calcular el área y el perímetro. Puede elegir entre un círculo, un triángulo, un rectángulo o salir del programa.
//Ingreso de Datos:

//Para cada figura seleccionada, el programa solicita al usuario ingresar los datos necesarios para el cálculo. Por ejemplo, para un círculo, se pide el radio; para un triángulo, la base y la altura; para un rectángulo, la longitud y el ancho.
//Cálculos y Resultados:

//El programa realiza los cálculos necesarios utilizando funciones específicas para cada tipo de figura.
//Después de realizar los cálculos, muestra el área y el perímetro de la figura seleccionada.
//Manejo de Errores:

//El programa maneja entradas no válidas, como ingresar texto en lugar de números o números negativos. Si la entrada no es válida, le indica al usuario que lo intente nuevamente.
//Salir del Programa:

//El usuario puede salir del programa en cualquier momento seleccionando la opción correspondiente en el menú.
    static void Main()
    {
        Console.WriteLine("Calculadora de Área y Perímetro de Figuras Geométricas");

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Calcular Área y Perímetro de un Círculo");
            Console.WriteLine("2. Calcular Área y Perímetro de un Triángulo");
            Console.WriteLine("3. Calcular Área y Perímetro de un Rectángulo");
            Console.WriteLine("4. Salir");

            // Leer la elección del usuario
            Console.Write("Seleccione una figura (1-4): ");
            string opcion = Console.ReadLine();

            // Procesar la elección del usuario
            switch (opcion)
            {
                case "1":
                    CalcularCirculo();
                    break;
                case "2":
                    CalcularTriangulo();
                    break;
                case "3":
                    CalcularRectangulo();
                    break;
                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    // Funciones de cálculo para diferentes figuras
    static void CalcularCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radio) && radio > 0)
        {
            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;
            MostrarResultado("Círculo", area, perimetro);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void CalcularTriangulo()
    {
        Console.Write("Ingrese la base del triángulo: ");
        if (double.TryParse(Console.ReadLine(), out double baseTriangulo) && baseTriangulo > 0)
        {
            Console.Write("Ingrese la altura del triángulo: ");
            if (double.TryParse(Console.ReadLine(), out double alturaTriangulo) && alturaTriangulo > 0)
            {
                double area = 0.5 * baseTriangulo * alturaTriangulo;
                double perimetro = 3 * baseTriangulo; // Asumiendo un triángulo equilátero
                MostrarResultado("Triángulo", area, perimetro);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void CalcularRectangulo()
    {
        Console.Write("Ingrese la longitud del rectángulo: ");
        if (double.TryParse(Console.ReadLine(), out double longitud) && longitud > 0)
        {
            Console.Write("Ingrese el ancho del rectángulo: ");
            if (double.TryParse(Console.ReadLine(), out double ancho) && ancho > 0)
            {
                double area = longitud * ancho;
                double perimetro = 2 * (longitud + ancho);
                MostrarResultado("Rectángulo", area, perimetro);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    // Función para mostrar el resultado del cálculo
    static void MostrarResultado(string figura, double area, double perimetro)
    {
        Console.WriteLine($"\nResultados para {figura}:");
        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }
}
