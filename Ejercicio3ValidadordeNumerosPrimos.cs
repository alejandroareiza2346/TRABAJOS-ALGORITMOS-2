using System;

class Program
{
    //Con este código, puedes verificar si un número ingresado por el usuario es un número primo o no. Aquí está lo que puedes hacer:

//Ingresar un número:

//El programa te solicitará que ingreses un número.
//Puedes ingresar cualquier número entero (positivo o negativo) para verificar si es primo o no.
//Verificar si el número es primo:

//Después de ingresar el número, el programa utilizará la función EsPrimo para determinar si es un número primo.
//Te mostrará un mensaje claro indicando si el número es primo o no.
//Salir del programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite un número.
//El programa mostrará un mensaje de despedida y terminará.
//vManejar entradas no válidas:

//El programa maneja entradas no válidas, por ejemplo, si ingresas texto en lugar de un número.
//Si la entrada no es válida, te indicará que intentes nuevamente.
    static void Main()
    {
        Console.WriteLine("Validador de Números Primos");

        while (true)
        {
            Console.Write("Ingrese un número (o '0' para salir): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            if (int.TryParse(input, out int numero))
            {
                if (EsPrimo(numero))
                {
                    Console.WriteLine($"{numero} es un número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} no es un número primo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
    }

    // Función para verificar si un número es primo
    static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
