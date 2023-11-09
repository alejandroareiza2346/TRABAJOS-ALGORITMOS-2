using System;

class Program
{
    //Con este programa de conversión de temperatura, puedes realizar varias acciones:

//Convertir de Celsius a Fahrenheit:

//Selecciona la opción 1 en el menú, ingresa la temperatura en grados Celsius y obtén la temperatura equivalente en grados Fahrenheit.
//Convertir de Fahrenheit a Celsius:

//Selecciona la opción 2 en el menú, ingresa la temperatura en grados Fahrenheit y obtén la temperatura equivalente en grados Celsius.
//Convertir de Celsius a Kelvin:

//Selecciona la opción 3 en el menú, ingresa la temperatura en grados Celsius y obtén la temperatura equivalente en Kelvin.
//Convertir de Kelvin a Celsius:

//Selecciona la opción 4 en el menú, ingresa la temperatura en Kelvin y obtén la temperatura equivalente en grados Celsius.
//Convertir de Fahrenheit a Kelvin:

//Selecciona la opción 5 en el menú, ingresa la temperatura en grados Fahrenheit y obtén la temperatura equivalente en Kelvin.
//Convertir de Kelvin a Fahrenheit:

//Selecciona la opción 6 en el menú, ingresa la temperatura en Kelvin y obtén la temperatura equivalente en grados Fahrenheit.
//Salir del Programa:

//Si deseas salir del programa, selecciona la opción 7 en el menú.
//El programa mostrará un mensaje de despedida y terminará.
//Manejar Entradas no Válidas:

//El programa maneja entradas no válidas, como ingresar texto en lugar de números.
//Si la entrada no es válida, te indicará que lo intentes nuevamente.
    static void Main()
    {
        Console.WriteLine("Conversor de Temperatura");

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
            Console.WriteLine("3. Convertir de Celsius a Kelvin");
            Console.WriteLine("4. Convertir de Kelvin a Celsius");
            Console.WriteLine("5. Convertir de Fahrenheit a Kelvin");
            Console.WriteLine("6. Convertir de Kelvin a Fahrenheit");
            Console.WriteLine("7. Salir");

            // Leer la elección del usuario
            Console.Write("Seleccione una conversión (1-7): ");
            string opcion = Console.ReadLine();

            // Procesar la elección del usuario
            switch (opcion)
            {
                case "1":
                    ConvertirCelsiusToFahrenheit();
                    break;
                case "2":
                    ConvertirFahrenheitToCelsius();
                    break;
                case "3":
                    ConvertirCelsiusToKelvin();
                    break;
                case "4":
                    ConvertirKelvinToCelsius();
                    break;
                case "5":
                    ConvertirFahrenheitToKelvin();
                    break;
                case "6":
                    ConvertirKelvinToFahrenheit();
                    break;
                case "7":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    // Funciones de conversión de temperatura
    static void ConvertirCelsiusToFahrenheit()
    {
        Console.Write("Ingrese la temperatura en Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            MostrarResultado("Celsius a Fahrenheit", fahrenheit);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirFahrenheitToCelsius()
    {
        Console.Write("Ingrese la temperatura en Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            MostrarResultado("Fahrenheit a Celsius", celsius);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirCelsiusToKelvin()
    {
        Console.Write("Ingrese la temperatura en Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double kelvin = celsius + 273.15;
            MostrarResultado("Celsius a Kelvin", kelvin);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirKelvinToCelsius()
    {
        Console.Write("Ingrese la temperatura en Kelvin: ");
        if (double.TryParse(Console.ReadLine(), out double kelvin))
        {
            double celsius = kelvin - 273.15;
            MostrarResultado("Kelvin a Celsius", celsius);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirFahrenheitToKelvin()
    {
        Console.Write("Ingrese la temperatura en Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
            MostrarResultado("Fahrenheit a Kelvin", kelvin);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirKelvinToFahrenheit()
    {
        Console.Write("Ingrese la temperatura en Kelvin: ");
        if (double.TryParse(Console.ReadLine(), out double kelvin))
        {
            double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
            MostrarResultado("Kelvin a Fahrenheit", fahrenheit);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    // Función para mostrar el resultado de la conversión
    static void MostrarResultado(string conversion, double resultado)
    {
        Console.WriteLine($"\nResultado de {conversion}: {resultado:F2}");
    }
}
