using System;

class Program {
    // Función para imprimir matrices
    static void ImprimirMatriz(int[,] matriz) {
        for (int fila = 0; fila < matriz.GetLength(0); fila++) {
            for (int columna = 0; columna < matriz.GetLength(1); columna++) {
                Console.Write(matriz[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main() {
        // 1. Dada una matriz cuadrada NxN recorrerla de arriba hacia abajo por columnas
        int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Recorrido de arriba hacia abajo por columnas:");
        for (int columna = 0; columna < matriz1.GetLength(1); columna++) {
            for (int fila = 0; fila < matriz1.GetLength(0); fila++) {
                Console.Write(matriz1[fila, columna] + "\t");
            }
            Console.WriteLine();
        }

        // 2. Dada una matriz cuadrada NxN recorrer sus filas una a una
        int[,] matriz2 = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
        Console.WriteLine("\nRecorrido de filas una a una:");
        for (int fila = 0; fila < matriz2.GetLength(0); fila++) {
            for (int columna = 0; columna < matriz2.GetLength(1); columna++) {
                Console.Write(matriz2[fila, columna] + "\t");
            }
            Console.WriteLine();
        }

        // 3. Dada una matriz cuadrada NxN, recorrer su primera columna desde la última posición hasta la primera,
        // luego la diagonal principal y luego la última columna, circunscribiendo una N en la matriz
        int[,] matriz3 = { { 11, 12, 13 }, { 14, 15, 16 }, { 17, 18, 19 } };
        Console.WriteLine("\nRecorrido circunscrito en forma de N:");
        for (int fila = matriz3.GetLength(0) - 1; fila >= 0; fila--) {
            Console.Write(matriz3[fila, 0] + "\t");
        }
        for (int diagonal = 0; diagonal < matriz3.GetLength(0); diagonal++) {
            Console.Write(matriz3[diagonal, diagonal] + "\t");
        }
        for (int fila = 0; fila < matriz3.GetLength(0); fila++) {
            Console.Write(matriz3[fila, matriz3.GetLength(1) - 1] + "\t");
        }
        Console.WriteLine();

        // 4. Dada una matriz cuadrada NxN, recorrer su última columna desde la ultima posición de la fila hasta la primera,
        // continuando con la diagonal secundaria y subiendo por la primera columna hasta la posición 0.0
        int[,] matriz4 = { { 21, 22, 23 }, { 24, 25, 26 }, { 27, 28, 29 } };
        Console.WriteLine("\nRecorrido en forma de U invertida:");
        for (int fila = matriz4.GetLength(0) - 1; fila >= 0; fila--) {
            Console.Write(matriz4[fila, matriz4.GetLength(1) - 1] + "\t");
        }
        for (int diagonalSecundaria = matriz4.GetLength(0) - 2; diagonalSecundaria >= 0; diagonalSecundaria--) {
            Console.Write(matriz4[diagonalSecundaria, matriz4.GetLength(0) - diagonalSecundaria - 1] + "\t");
        }
        for (int fila = 0; fila < matriz4.GetLength(0); fila++) {
            Console.Write(matriz4[fila, 0] + "\t");
        }
        Console.WriteLine();
    }
}
//Comentarios y Explicaciones:
//ImprimirMatriz Function:

//Esta función toma una matriz como parámetro e imprime cada elemento en formato tabular.
//Main Method:

//Ejercicio 1 (Recorrido de arriba hacia abajo por columnas):

//Se utiliza un bucle for anidado para recorrer la matriz de arriba hacia abajo por columnas.
//Cada elemento se imprime en formato tabular.
//Ejercicio 2 (Recorrido de filas una a una):

//Otro bucle for anidado se utiliza para recorrer la matriz por filas.
//Cada fila se imprime completa antes de pasar a la siguiente.
//Ejercicio 3 (Recorrido circunscrito en forma de N):

//Se utilizan tres bucles for para recorrer la primera columna desde la última posición hasta la primera.
//Luego, se recorre la diagonal principal.
//Finalmente, se recorre la última columna.
//Ejercicio 4 (Recorrido en forma de U invertida):

//Tres bucles for se utilizan para recorrer la última columna desde la última posición hasta la primera.
//Luego, se continúa con la diagonal secundaria.
//Finalmente, se sube por la primera columna hasta la posición 0.0.