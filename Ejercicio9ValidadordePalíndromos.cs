using System;

class Program
{
    //Con este programa validador de palíndromos, puedes realizar varias acciones:

//Verificar si una Palabra o Frase es un Palíndromo:

//Ingresa una palabra o frase cuando se te solicite.
//El programa verificará si la entrada es un palíndromo y te proporcionará el resultado.
//Salir del Programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite la palabra o frase.
//El programa mostrará un mensaje de despedida y terminará.
//Experimentar con Diferentes Palíndromos:

//Ingresa diversas palabras o frases para verificar si son palíndromos.
//Observa cómo el programa elimina espacios y distingue entre mayúsculas y minúsculas durante la verificación.
//Explorar Casos Especiales:

//Prueba con palabras o frases que contengan espacios, letras mayúsculas y minúsculas para ver cómo el programa maneja estos casos.
    static void Main()
    {
        Console.WriteLine("Validador de Palíndromos");

        while (true)
        {
            Console.Write("Ingrese una palabra o frase (o '0' para salir): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            if (EsPalindromo(input))
            {
                Console.WriteLine("¡Es un palíndromo!");
            }
            else
            {
                Console.WriteLine("No es un palíndromo.");
            }
        }
    }

    // Función para verificar si una cadena es un palíndromo
    static bool EsPalindromo(string str)
    {
        // Eliminar espacios y convertir a minúsculas para la comparación
        str = str.Replace(" ", "").ToLower();

        // Comparar la cadena original con su versión invertida
        return str == InvertirCadena(str);
    }

    // Función para invertir una cadena
    static string InvertirCadena(string str)
    {
        char[] caracteres = str.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
