using System;

class Program
{
    //Suma: Ingresa dos números y obtén la suma.
//Resta: Ingresa dos números y obtén la resta.
//Multiplicación: Ingresa dos números y obtén el producto.
//División: Ingresa dos números y obtén el cociente. La división por cero está manejada.
//Potenciación: Ingresa dos números y obtén el resultado de elevar el primero al segundo.
//Raíz Cuadrada: Ingresa un número y obtén su raíz cuadrada. El programa maneja números negativos.
//Para usar la calculadora:Selecciona la operación deseada ingresando el número correspondiente. Sigue las instrucciones para ingresar los números necesarios para la operación. Observa el resultado de la operación.
    static void Main()
    {
        while (true)
        {
            MostrarMenu();

            int opcion = LeerEntero("Ingrese el número de la operación: ");

            if (opcion == 0)
            {
                Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                break;
            }

            RealizarOperacion(opcion);
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Potenciación");
        Console.WriteLine("6. Raíz Cuadrada");
        Console.WriteLine("0. Salir");
    }

    static void RealizarOperacion(int opcion)
    {
        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = OperacionBinaria(Suma);
                break;
            case 2:
                resultado = OperacionBinaria(Resta);
                break;
            case 3:
                resultado = OperacionBinaria(Multiplicacion);
                break;
            case 4:
                resultado = OperacionBinaria(Division);
                break;
            case 5:
                resultado = OperacionBinaria(Potenciacion);
                break;
            case 6:
                resultado = OperacionUnaria(RaizCuadrada);
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    static double OperacionBinaria(Func<double, double, double> operacion)
    {
        double num1 = LeerDouble("Ingrese el primer número: ");
        double num2 = LeerDouble("Ingrese el segundo número: ");

        return operacion(num1, num2);
    }

    static double OperacionUnaria(Func<double, double> operacion)
    {
        double num = LeerDouble("Ingrese el número: ");
        return operacion(num);
    }

    static double Suma(double a, double b) => a + b;

    static double Resta(double a, double b) => a - b;

    static double Multiplicacion(double a, double b) => a * b;

    static double Division(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN;
        }
    }

    static double Potenciacion(double a, double b) => Math.Pow(a, b);

    static double RaizCuadrada(double a)
    {
        if (a >= 0)
            return Math.Sqrt(a);
        else
        {
            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
            return double.NaN;
        }
    }

    static double LeerDouble(string mensaje)
    {
        double resultado;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out resultado))
                return resultado;

            Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
        }
    }

    static int LeerEntero(string mensaje)
    {
        int resultado;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out resultado))
                return resultado;

            Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
        }
    }
}
