using System;

class Program
{
    static void Main()
    {
        // Inicialización de variables
        Random random = new Random();
        int numeroAdivinar = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
        int intentos = 0;
        int intentoUsuario;

        // Mensaje de bienvenida
        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

        // Bucle principal del juego
        do
        {
            // Solicitar la suposición del usuario
            Console.Write("Introduce tu suposición: ");
            
            // Verificar si la entrada del usuario es un número válido
            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                intentos++; // Incrementar el contador de intentos

                // Comparar la suposición del usuario con el número a adivinar
                if (intentoUsuario < numeroAdivinar)
                {
                    Console.WriteLine("El número que estás buscando es mayor.");
                }
                else if (intentoUsuario > numeroAdivinar)
                {
                    Console.WriteLine("El número que estás buscando es menor.");
                }
                else
                {
                    // Mensaje de felicitaciones si el usuario adivina el número
                    Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAdivinar} en {intentos} intentos.");
                }
            }
            else
            {
                // Mensaje de error si la entrada no es un número válido
                Console.WriteLine("Por favor, introduce un número válido.");
            }

        } while (intentoUsuario != numeroAdivinar); // Continuar el bucle mientras el usuario no adivine el número

        // Leer la entrada del usuario al final del juego
        Console.ReadLine();
    }
}
