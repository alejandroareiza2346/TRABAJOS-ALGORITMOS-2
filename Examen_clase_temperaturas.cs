using System;

namespace Temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo para almacenar las temperaturas de un día
            double[] temperaturas = new double[24];

            // Llenar el arreglo con temperaturas (puedes hacerlo manualmente o mediante entrada del usuario)
            // (En este ejemplo, se asume que las temperaturas ya están asignadas de alguna manera)

            // Llamar a las funciones y mostrar los resultados
            double promedio = CalcularPromedio(temperaturas);
            int celdaMasFria = EncontrarCeldaMasFria(temperaturas);
            int celdaMasCaliente = EncontrarCeldaMasCaliente(temperaturas);
            double valorMasFrio = temperaturas[celdaMasFria];
            double valorMasCaliente = temperaturas[celdaMasCaliente];

            // Mostrar los resultados
            Console.WriteLine("Promedio de temperatura: " + promedio);
            Console.WriteLine("Número de celda con la temperatura más fría: " + celdaMasFria);
            Console.WriteLine("Número de celda con la temperatura más caliente: " + celdaMasCaliente);
            Console.WriteLine("Valor de la temperatura más fría: " + valorMasFrio);
            Console.WriteLine("Valor de la temperatura más caliente: " + valorMasCaliente);
        }

        // Función para calcular el promedio de temperaturas
        static double CalcularPromedio(double[] temperaturas)
        {
            // Calcular la suma de todas las temperaturas
            double suma = 0;
            foreach (double temp in temperaturas)
            {
                suma += temp;
            }

            // Calcular el promedio
            return suma / temperaturas.Length;
        }

        // Función para encontrar la celda con la temperatura más fría
        static int EncontrarCeldaMasFria(double[] temperaturas)
        {
            double tempMasFria = double.MaxValue;
            int celdaMasFria = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] < tempMasFria)
                {
                    tempMasFria = temperaturas[i];
                    celdaMasFria = i;
                }
            }

            return celdaMasFria;
        }

        // Función para encontrar la celda con la temperatura más caliente
        static int EncontrarCeldaMasCaliente(double[] temperaturas)
        {
            double tempMasCaliente = double.MinValue;
            int celdaMasCaliente = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > tempMasCaliente)
                {
                    tempMasCaliente = temperaturas[i];
                    celdaMasCaliente = i;
                }
            }

            return celdaMasCaliente;
        }
    }
}
//Explicación y Documentación:
//Main Method:

//Se crea un arreglo temperaturas para almacenar las temperaturas del día.
//Se llama a las funciones para calcular el promedio, encontrar la celda más fría y más caliente, y se muestran los resultados.
//Funciones:

//CalcularPromedio:

//Calcula y devuelve el promedio de las temperaturas en el arreglo.
//EncontrarCeldaMasFria:

//Encuentra y devuelve el índice de la celda con la temperatura más fría en el arreglo.
//EncontrarCeldaMasCaliente:

//Encuentra y devuelve el índice de la celda con la temperatura más caliente en el arreglo.
//Comentarios Adicionales:

//Se ha agregado un comentario indicando que el llenado del arreglo con temperaturas puede hacerse manualmente o mediante entrada del usuario.