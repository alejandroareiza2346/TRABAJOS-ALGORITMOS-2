using System;
using System.Security.Cryptography;

class Program
{
    //Con este generador de contraseñas, puedes realizar varias acciones:

//Generar Contraseñas Aleatorias:

//Ingresa la longitud deseada para la contraseña.
//Selecciona los requisitos que quieres incluir (mayúsculas, minúsculas, números, caracteres especiales).
//Salir del Programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite la longitud de la contraseña.
//El programa mostrará un mensaje de despedida y terminará.
//Personalizar Contraseñas:

//Experimenta con diferentes longitudes y configuraciones de requisitos para obtener contraseñas que se ajusten a tus necesidades de seguridad.
//Manejar Entradas no Válidas:

//El programa valida que la longitud ingresada sea un número válido mayor que cero.
//También maneja las respuestas a las preguntas de requisitos, asegurándose de que solo se acepten 'S' o 'N'.
//Obtener Contraseñas Seguras:

//Al incluir diferentes conjuntos de caracteres en la generación de contraseñas, puedes obtener contraseñas más seguras y variadas.
//Experimentar con Diferentes Escenarios:

//Puedes probar diferentes combinaciones de requisitos para ver cómo afectan la generación de contraseñas.
    static void Main()
    {
        Console.WriteLine("Generador de Contraseñas");

        while (true)
        {
            Console.Write("Longitud de la contraseña (o '0' para salir): ");
            string longitudInput = Console.ReadLine();

            if (longitudInput == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            if (int.TryParse(longitudInput, out int longitud) && longitud > 0)
            {
                Console.Write("Incluir mayúsculas (S/N): ");
                bool incluirMayusculas = Console.ReadLine().Trim().ToUpper() == "S";

                Console.Write("Incluir minúsculas (S/N): ");
                bool incluirMinusculas = Console.ReadLine().Trim().ToUpper() == "S";

                Console.Write("Incluir números (S/N): ");
                bool incluirNumeros = Console.ReadLine().Trim().ToUpper() == "S";

                Console.Write("Incluir caracteres especiales (S/N): ");
                bool incluirCaracteresEspeciales = Console.ReadLine().Trim().ToUpper() == "S";

                // Generar y mostrar la contraseña
                string contraseña = GenerarContraseña(longitud, incluirMayusculas, incluirMinusculas, incluirNumeros, incluirCaracteresEspeciales);
                Console.WriteLine($"\nContraseña generada: {contraseña}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
    }

    // Función para generar una contraseña aleatoria
    static string GenerarContraseña(int longitud, bool incluirMayusculas, bool incluirMinusculas, bool incluirNumeros, bool incluirCaracteresEspeciales)
    {
        const string caracteresMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string caracteresMinusculas = "abcdefghijklmnopqrstuvwxyz";
        const string caracteresNumeros = "0123456789";
        const string caracteresEspeciales = "!@#$%^&*()_+-=[]{}|;:'<>,.?/";

        // Crear una cadena con todos los caracteres posibles basados en los requisitos
        string caracteresPosibles = "";
        caracteresPosibles += incluirMayusculas ? caracteresMayusculas : "";
        caracteresPosibles += incluirMinusculas ? caracteresMinusculas : "";
        caracteresPosibles += incluirNumeros ? caracteresNumeros : "";
        caracteresPosibles += incluirCaracteresEspeciales ? caracteresEspeciales : "";

        // Verificar que al menos un conjunto de caracteres esté seleccionado
        if (caracteresPosibles == "")
        {
            return "Error: No se seleccionaron requisitos válidos.";
        }

        // Generar la contraseña aleatoria
        char[] contraseñaArray = new char[longitud];
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            byte[] randomBytes = new byte[longitud];
            rng.GetBytes(randomBytes);

            for (int i = 0; i < longitud; i++)
            {
                contraseñaArray[i] = caracteresPosibles[randomBytes[i] % caracteresPosibles.Length];
            }
        }

        return new string(contraseñaArray);
    }
}
