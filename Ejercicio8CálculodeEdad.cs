using System;

class Program
{
    //Con este programa de cálculo de edad, puedes realizar varias acciones:

//Calcular Edad:

//Ingresa tu fecha de nacimiento en el formato "yyyy-mm-dd".
//El programa calculará automáticamente tu edad en años y te mostrará el resultado.
//Salir del Programa:

//Si deseas salir del programa, simplemente ingresa '0' cuando se te solicite la fecha de nacimiento.
//El programa mostrará un mensaje de despedida y terminará.
//Manejar Fechas no Válidas:

//El programa valida que la fecha de nacimiento ingresada no sea en el futuro.
//Si ingresas una fecha en el formato incorrecto o en el futuro, el programa te indicará que lo intentes nuevamente.
//Experimentar con Diferentes Fechas:

//Ingresa diversas fechas de nacimiento para observar cómo cambia tu edad.
//Puedes verificar cómo la edad se ajusta según si ya ha pasado tu cumpleaños en el año actual o no.
    static void Main()
    {
        Console.WriteLine("Calculadora de Edad");

        while (true)
        {
            Console.Write("Ingrese su fecha de nacimiento (yyyy-mm-dd) o '0' para salir: ");
            string fechaNacimientoInput = Console.ReadLine();

            if (fechaNacimientoInput == "0")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            if (DateTime.TryParse(fechaNacimientoInput, out DateTime fechaNacimiento) && ValidarFechaNacimiento(fechaNacimiento))
            {
                // Calcular la edad y mostrar el resultado
                int edad = CalcularEdad(fechaNacimiento);
                Console.WriteLine($"Su edad es: {edad} años");
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento no válida. Intente de nuevo.");
            }
        }
    }

    // Función para validar la fecha de nacimiento
    static bool ValidarFechaNacimiento(DateTime fechaNacimiento)
    {
        // Validar que la fecha de nacimiento no sea en el futuro
        return fechaNacimiento <= DateTime.Now;
    }

    // Función para calcular la edad
    static int CalcularEdad(DateTime fechaNacimiento)
    {
        // Calcular la edad restando el año de nacimiento del año actual
        int edad = DateTime.Now.Year - fechaNacimiento.Year;

        // Ajustar la edad si aún no ha pasado el día de nacimiento en este año
        if (DateTime.Now.Month < fechaNacimiento.Month || (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
        {
            edad--;
        }

        return edad;
    }
}
