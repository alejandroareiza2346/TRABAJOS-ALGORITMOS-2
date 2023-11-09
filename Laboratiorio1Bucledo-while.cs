using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Ingresar números hasta que se ingrese un número negativo");
        int numero1;
        do
        {
            Console.Write("Ingresa un número (ingresa un número negativo para salir): ");
            numero1 = int.Parse(Console.ReadLine());
        } while (numero1 >= 0);

        Console.WriteLine("\nEjercicio 2: Generar números aleatorios hasta que se genere un número mayor que 90");
        Random rand = new Random();
        int numero2;
        do
        {
            numero2 = rand.Next(1, 101);
            Console.WriteLine("Número generado: " + numero2);
        } while (numero2 <= 90);

        Console.WriteLine("\nEjercicio 3: Sumar números ingresados por el usuario hasta que ingrese un número cero");
        int numero3;
        int suma = 0;
        do
        {
            Console.Write("Ingresa un número (ingresa 0 para salir): ");
            numero3 = int.Parse(Console.ReadLine());
            suma += numero3;
        } while (numero3 != 0);
        Console.WriteLine("La suma de los números ingresados es: " + suma);

        Console.WriteLine("\nEjercicio 4: Solicitar una contraseña al usuario hasta que ingrese la contraseña correcta");
        string contraseñaCorrecta = "secreto";
        string contraseñaIngresada;
        do
        {
            Console.Write("Ingresa la contraseña: ");
            contraseñaIngresada = Console.ReadLine();
        } while (contraseñaIngresada != contraseñaCorrecta);
        Console.WriteLine("¡Contraseña correcta!");

        Console.WriteLine("\nEjercicio 5: Adivinar un número secreto entre 1 y 100");
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int adivinanza;
        do
        {
            Console.Write("Adivina el número secreto (entre 1 y 100): ");
            adivinanza = int.Parse(Console.ReadLine());
            if (adivinanza < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (adivinanza > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
        } while (adivinanza != numeroSecreto);
        Console.WriteLine("¡Adivinaste el número secreto!");

        Console.WriteLine("\nEjercicio 6: Calcular la suma de los números pares entre 1 y 100");
        int numero6 = 2;
        int sumaPares = 0;
        do
        {
            sumaPares += numero6;
            numero6 += 2;
        } while (numero6 <= 100);
        Console.WriteLine("La suma de los números pares entre 1 y 100 es: " + sumaPares);

        Console.WriteLine("\nEjercicio 7: Contar la cantidad de dígitos en un número ingresado por el usuario");
        Console.Write("Ingresa un número: ");
        int numero7 = int.Parse(Console.ReadLine());
        int contadorDigitos = 0;
        do
        {
            numero7 /= 10;
            contadorDigitos++;
        } while (numero7 != 0);
        Console.WriteLine("La cantidad de dígitos en el número ingresado es: " + contadorDigitos);

        Console.WriteLine("\nEjercicio 8: Jugar al piedra-papel-tijeras hasta que se decida salir");
        string opcionJuego;
        do
        {
            Console.Write("¿Piedra, papel o tijeras? (o escribe 'salir' para terminar): ");
            opcionJuego = Console.ReadLine().ToLower();
        } while (opcionJuego != "salir");
        Console.WriteLine("¡Juego terminado!");

        Console.WriteLine("\nEjercicio 9: Imprimir los números del 1 al 10 en orden inverso");
        int numero9 = 10;
        do
        {
            Console.WriteLine(numero9);
            numero9--;
        } while (numero9 >= 1);

        Console.WriteLine("\nEjercicio 10: Agregar nombres a una lista hasta que se ingrese 'fin'");
        List<string> nombres = new List<string>();
        string nombre;
        do
        {
            Console.Write("Ingresa un nombre (o escribe 'fin' para terminar): ");
            nombre = Console.ReadLine();
            if (nombre.ToLower() != "fin")
            {
                nombres.Add(nombre);
            }
        } while (nombre.ToLower() != "fin");
        Console.WriteLine("Nombres ingresados:");
        foreach (string n in nombres)
        {
            Console.WriteLine(n);
        }
    }
}
