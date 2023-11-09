using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Imprimir números del 1 al 10");
        int numero1 = 1;
        while (numero1 <= 10)
        {
            Console.WriteLine(numero1);
            numero1++;
        }

        Console.WriteLine("\nEjercicio 2: Sumar números pares del 1 al 100");
        int numero2 = 2;
        int sumaPares = 0;
        while (numero2 <= 100)
        {
            sumaPares += numero2;
            numero2 += 2;
        }
        Console.WriteLine("La suma de los números pares del 1 al 100 es: " + sumaPares);

        Console.WriteLine("\nEjercicio 3: Juego de adivinanza de número secreto");
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int intentos = 0;
        int adivinanza;
        do
        {
            Console.Write("Adivina el número secreto (entre 1 y 100): ");
            adivinanza = int.Parse(Console.ReadLine());
            intentos++;
            if (adivinanza < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (adivinanza > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
        } while (adivinanza != numeroSecreto);
        Console.WriteLine("¡Adivinaste el número secreto en " + intentos + " intentos!");

        Console.WriteLine("\nEjercicio 4: Contar vocales en una cadena");
        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine().ToLower();
        int contadorVocales = 0;
        int i = 0;
        while (i < cadena.Length)
        {
            char caracter = cadena[i];
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contadorVocales++;
            }
            i++;
        }
        Console.WriteLine("La cadena tiene " + contadorVocales + " vocales.");

        Console.WriteLine("\nEjercicio 5: Calcular el factorial de un número");
        Console.Write("Ingresa un número: ");
        int numeroFactorial = int.Parse(Console.ReadLine());
        long factorial = 1;
        int j = 1;
        while (j <= numeroFactorial)
        {
            factorial *= j;
            j++;
        }
        Console.WriteLine("El factorial de " + numeroFactorial + " es " + factorial);

        Console.WriteLine("\nEjercicio 6: Contador de tiempo regresivo");
        int tiempo = 10;
        while (tiempo > 0)
        {
            Console.WriteLine(tiempo);
            tiempo--;
        }
        Console.WriteLine("¡Tiempo terminado!");

        Console.WriteLine("\nEjercicio 7: Encontrar el número más grande en una lista");
        int[] listaNumeros = { 5, 10, 3, 25, 17, 8, 30 };
        int maximo = listaNumeros[0];
        int k = 1;
        while (k < listaNumeros.Length)
        {
            if (listaNumeros[k] > maximo)
            {
                maximo = listaNumeros[k];
            }
            k++;
        }
        Console.WriteLine("El número más grande en la lista es " + maximo);

        Console.WriteLine("\nEjercicio 8: Calcular la suma de los dígitos de un número entero");
        Console.Write("Ingresa un número entero: ");
        int numeroEntero = int.Parse(Console.ReadLine());
        int sumaDigitos = 0;
        int digito;
        while (numeroEntero > 0)
        {
            digito = numeroEntero % 10;
            sumaDigitos += digito;
            numeroEntero /= 10;
        }
        Console.WriteLine("La suma de los dígitos es: " + sumaDigitos);

        Console.WriteLine("\nEjercicio 9: Imprimir una tabla de multiplicar");
        Console.Write("Ingresa un número para la tabla de multiplicar: ");
        int numeroTabla = int.Parse(Console.ReadLine());
        int multiplicador = 1;
        while (multiplicador <= 10)
        {
            Console.WriteLine(numeroTabla + " x " + multiplicador + " = " + (numeroTabla * multiplicador));
            multiplicador++;
        }

        Console.WriteLine("\nEjercicio 10: Juego de adivinanza de palabra secreta");
        string palabraSecreta = "programacion";
        string adivinanzaPalabra;
        int intentosPalabra = 0;
        do
        {
            Console.Write("Adivina la palabra secreta: ");
            adivinanzaPalabra = Console.ReadLine().ToLower();
            intentosPalabra++;
        } while (adivinanzaPalabra != palabraSecreta);
        Console.WriteLine("¡Adivinaste la palabra secreta en " + intentosPalabra + " intentos!");
    }
}
