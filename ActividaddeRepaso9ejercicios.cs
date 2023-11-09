using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Suma de dos números");
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2;
        Console.WriteLine("La suma es: " + suma);

        Console.WriteLine("\nEjercicio 2: Operaciones básicas (+, -, *, /)");
        Console.Write("Ingrese el primer número: ");
        double numero1Oper = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2Oper = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la operación (+, -, *, /): ");
        char operacion = Console.ReadLine()[0];

        double resultado = 0;

        switch (operacion)
        {
            case '+':
                resultado = numero1Oper + numero2Oper;
                break;
            case '-':
                resultado = numero1Oper - numero2Oper;
                break;
            case '*':
                resultado = numero1Oper * numero2Oper;
                break;
            case '/':
                if (numero2Oper != 0)
                    resultado = numero1Oper / numero2Oper;
                else
                    Console.WriteLine("No se puede dividir por cero.");
                break;
            default:
                Console.WriteLine("Operación no válida. Las operaciones válidas son: +, -, *, /");
                break;
        }

        Console.WriteLine("El resultado es: " + resultado);

        Console.WriteLine("\nEjercicio 3: Tabla de multiplicar");
        Console.Write("Ingrese un número: ");
        int numeroTabla = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numeroTabla + " x " + i + " = " + (numeroTabla * i));
        }

        Console.WriteLine("\nEjercicio 4: Números del 1 al 10 en orden ascendente");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nEjercicio 5: Números del 10 al 1 en orden descendente");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nEjercicio 6: Par o impar");
        Console.Write("Ingrese un número: ");
        int numeroParImpar = int.Parse(Console.ReadLine());

        if (numeroParImpar % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }

        Console.WriteLine("\nEjercicio 7: Factorial de un número");
        Console.Write("Ingrese un número: ");
        int numeroFactorial = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 1; i <= numeroFactorial; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial de " + numeroFactorial + " es " + factorial);

        Console.WriteLine("\nEjercicio 8: Conversión de grados Celsius a grados Fahrenheit");
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);

        Console.WriteLine("\nEjercicio 9: Verificación de número primo");
        Console.Write("Ingrese un número: ");
        int numeroPrimo = int.Parse(Console.ReadLine());

        bool esPrimo = true;
        if (numeroPrimo < 2)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i * i <= numeroPrimo; i++)
            {
                if (numeroPrimo % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("El número es primo.");
        }
        else
        {
            Console.WriteLine("El número no es primo.");
        }
    }
}
