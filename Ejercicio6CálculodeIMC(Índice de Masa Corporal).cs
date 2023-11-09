using System;

class Program
{
    //Con este programa, puedes realizar varias acciones relacionadas con el cálculo del Índice de Masa Corporal (IMC):

//Calcular el IMC:

//Ingresa tu peso en kilogramos y tu altura en metros cuando se te solicite.
//El programa calculará automáticamente tu IMC utilizando la fórmula IMC = peso / (altura * altura).
//Obtener la Clasificación del IMC:

//Después de calcular el IMC, el programa mostrará la clasificación correspondiente según los estándares comunes.
//Las clasificaciones incluyen "Bajo peso", "Peso normal", "Sobrepeso" y diferentes niveles de "Obesidad".
//Explorar Diferentes Escenarios:

//Experimenta ingresando diferentes valores de peso y altura para observar cómo cambia la clasificación del IMC.
//Observa cómo la clasificación varía entre las categorías mencionadas anteriormente.
//Salir del Programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite el peso.
//El programa mostrará un mensaje de despedida y terminará.
//Manejar Entradas no Válidas:

//El programa maneja entradas no válidas, como ingresar texto o números negativos.
//Si la entrada no es válida, te indicará que lo intentes nuevamente.
    static void Main()
    {
        Console.WriteLine("Calculador de Índice de Masa Corporal (IMC)");

        while (true)
        {
            Console.Write("Ingrese su peso en kilogramos (o '0' para salir): ");
            string pesoInput = Console.ReadLine();

            if (pesoInput == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            Console.Write("Ingrese su altura en metros: ");
            string alturaInput = Console.ReadLine();

            if (double.TryParse(pesoInput, out double peso) && double.TryParse(alturaInput, out double altura) && altura > 0)
            {
                // Calcular el IMC y mostrar la clasificación
                double imc = CalcularIMC(peso, altura);
                MostrarClasificacionIMC(imc);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }
    }

    // Función para calcular el IMC
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    // Función para mostrar la clasificación del IMC
    static void MostrarClasificacionIMC(double imc)
    {
        Console.WriteLine($"\nSu IMC es: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Clasificación: Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Clasificación: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Clasificación: Sobrepeso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Clasificación: Obesidad (Clase I)");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Clasificación: Obesidad (Clase II)");
        }
        else
        {
            Console.WriteLine("Clasificación: Obesidad extrema (Clase III)");
        }
    }
}
