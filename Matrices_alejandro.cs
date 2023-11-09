using System;

class Program {
    static void Main() {
        // 1. Declarar una matriz de enteros y mostrar su contenido en la consola.
        int[,] matrizEnteros = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Contenido de la matriz:");
        for (int fila = 0; fila < 3; fila++) {
            for (int columna = 0; columna < 3; columna++) {
                Console.Write(matrizEnteros[fila, columna] + " ");
            }
            Console.WriteLine();
        }

        // ¡Agreguemos un espacio entre los resultados de los vectores y las matrices!
        Console.WriteLine();

        // 2. Realizar la suma de dos matrices y mostrar el resultado.
        int[,] matrizA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrizB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        int[,] resultadoSuma = new int[3, 3];

        Console.WriteLine("Resultado de la suma de matrices:");
        for (int fila = 0; fila < 3; fila++) {
            for (int columna = 0; columna < 3; columna++) {
                resultadoSuma[fila, columna] = matrizA[fila, columna] + matrizB[fila, columna];
                Console.Write(resultadoSuma[fila, columna] + " ");
            }
            Console.WriteLine();
        }

        // 3. Multiplicar una matriz por un escalar.
        int escalar = 2;
        int[,] matrizOriginal = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] resultadoMultiplicacion = new int[3, 3];

        Console.WriteLine("\nResultado de la multiplicación por escalar:");
        for (int fila = 0; fila < 3; fila++) {
            for (int columna = 0; columna < 3; columna++) {
                resultadoMultiplicacion[fila, columna] = escalar * matrizOriginal[fila, columna];
                Console.Write(resultadoMultiplicacion[fila, columna] + " ");
            }
            Console.WriteLine();
        }

        // 4. Encontrar el determinante de una matriz cuadrada.
        int[,] matrizCuadrada = { { 2, 3, 1 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int determinante = DeterminanteMatriz(matrizCuadrada);
        Console.WriteLine("\nEl determinante de la matriz cuadrada es: " + determinante);
    }

    // Función para encontrar el determinante de una matriz 3x3.
    static int DeterminanteMatriz(int[,] matriz) {
        int det = 0;
        for (int i = 0; i < 3; i++) {
            det += (matriz[0, i] * (matriz[1, (i + 1) % 3] * matriz[2, (i + 2) % 3] - matriz[1, (i + 2) % 3] * matriz[2, (i + 1) % 3]));
        }
        return det;
    }
}
//Importaciones (using): Solo se importa el espacio de nombres System.

//Matrices:

//Se declara una matriz de enteros matrizEnteros y se imprime su contenido.
//Se realiza la suma de dos matrices y se muestra el resultado.
//Se multiplica una matriz por un escalar y se muestra el resultado.
//Se encuentra el determinante de una matriz cuadrada utilizando una función llamada DeterminanteMatriz.