using System;

class Program
{
    //Este código es un programa simple de consola en C# que permite al usuario convertir entre diferentes unidades de medida, como longitud, peso o volumen. Aquí hay un resumen de lo que puede hacer:

//Menú de Opciones:

//Al ejecutar el programa, se presenta un menú con las siguientes opciones:
//Convertir Longitud
//Convertir Peso
//Convertir Volumen
//Salir
//Convertir Longitud:

//Si el usuario elige la opción de convertir longitud, se le pedirá ingresar una longitud en metros.
//El programa convertirá esa longitud a pulgadas (1 metro = 39.37 pulgadas) y mostrará el resultado.
//Convertir Peso:

//Si el usuario elige la opción de convertir peso, se le pedirá ingresar un peso en kilogramos.
//El programa convertirá ese peso a libras (1 kilogramo = 2.20462 libras) y mostrará el resultado.
//Convertir Volumen:

//Si el usuario elige la opción de convertir volumen, se le pedirá ingresar un volumen en litros.
//El programa convertirá ese volumen a galones (1 litro = 0.264172 galones) y mostrará el resultado.
//Manejo de Errores:

//El programa realiza ciertas verificaciones para asegurarse de que las entradas del usuario sean números válidos. Si el usuario ingresa algo que no es un número, se le informará que la entrada no es válida y se le pedirá que lo intente de nuevo.
//Salir:

//El usuario puede elegir salir del programa en cualquier momento seleccionando la opción correspondiente en el menú.
    static void Main()
    {
        Console.WriteLine("Programa de Conversión de Unidades");
        
        // Menú de opciones
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Convertir Longitud");
            Console.WriteLine("2. Convertir Peso");
            Console.WriteLine("3. Convertir Volumen");
            Console.WriteLine("4. Salir");
            
            // Leer la elección del usuario
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            // Procesar la elección del usuario
            switch (opcion)
            {
                case "1":
                    ConvertirLongitud();
                    break;
                case "2":
                    ConvertirPeso();
                    break;
                case "3":
                    ConvertirVolumen();
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

    // Funciones de conversión
    static void ConvertirLongitud()
    {
        Console.Write("Ingrese la longitud en metros: ");
        if (double.TryParse(Console.ReadLine(), out double metros))
        {
            double pulgadas = metros * 39.37;
            Console.WriteLine($"{metros} metros es igual a {pulgadas} pulgadas.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirPeso()
    {
        Console.Write("Ingrese el peso en kilogramos: ");
        if (double.TryParse(Console.ReadLine(), out double kilogramos))
        {
            double libras = kilogramos * 2.20462;
            Console.WriteLine($"{kilogramos} kilogramos es igual a {libras} libras.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }

    static void ConvertirVolumen()
    {
        Console.Write("Ingrese el volumen en litros: ");
        if (double.TryParse(Console.ReadLine(), out double litros))
        {
            double galones = litros * 0.264172;
            Console.WriteLine($"{litros} litros es igual a {galones} galones.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo.");
        }
    }
}
