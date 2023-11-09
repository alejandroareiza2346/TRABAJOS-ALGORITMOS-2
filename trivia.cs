using System;

class Trivia
{
    static void Main()
    {
        int score = 0;

        // Array bidimensional para almacenar preguntas y respuestas
        string[,] preguntasRespuestas = new string[,]
        {
            {"¿Cuál es la capital de Francia?", "a) París\nb) Madrid\nc) Roma", "a"},
            {"¿Cuál es el planeta más grande del sistema solar?", "a) Marte\nb) Júpiter\nc) Venus", "b"},
            {"¿Quién escribió 'Romeo y Julieta'?", "a) Charles Dickens\nb) William Shakespeare\nc) Jane Austen", "b"},
            {"¿Cuántos continentes hay en el mundo?", "a) 5\nb) 7\nc) 10", "c"},
            {"¿Cuál es el río más largo del mundo?", "a) Amazonas\nb) Nilo\nc) Yangtsé", "a"},
            {"¿En qué año se fundó Microsoft?", "a) 1975\nb) 1985\nc) 1995", "c"},
            {"¿Quién pintó la Mona Lisa?", "a) Vincent van Gogh\nb) Leonardo da Vinci\nc) Pablo Picasso", "b"},
            {"¿Cuál es el componente más abundante en la atmósfera de la Tierra?", "a) Nitrógeno\nb) Oxígeno\nc) Dióxido de carbono", "c"},
            {"¿En qué año comenzó la Primera Guerra Mundial?", "a) 1905\nb) 1914\nc) 1920", "b"},
            {"¿Cuál es la velocidad de la luz en el vacío?", "a) 299,792 km/s\nb) 150,000 km/s\nc) 450,000 km/s", "a"}
        };

        Console.WriteLine("¡Bienvenido a la Trivia!");
        Console.WriteLine("Responde correctamente a las siguientes preguntas:");

        // Iterar a través de las preguntas
        for (int i = 0; i < preguntasRespuestas.GetLength(0); i++)
        {
            string pregunta = preguntasRespuestas[i, 0];
            string opciones = preguntasRespuestas[i, 1];
            string respuestaCorrecta = preguntasRespuestas[i, 2];

            // Mostrar la pregunta, opciones y respuestas al usuario
            Console.WriteLine($"\n{i + 1}. {pregunta}");
            Console.WriteLine(opciones);

            // Leer la respuesta del usuario
            Console.Write("Respuesta: ");
            string respuestaUsuario = Console.ReadLine().ToLower();

            // Verificar si la respuesta del usuario es correcta
            if (respuestaUsuario == respuestaCorrecta)
            {
                Console.WriteLine($"¡Correcto! {preguntasRespuestas[i, 1]}");
                score++;
            }
            else
            {
                // Mostrar la respuesta correcta si la respuesta del usuario es incorrecta
                Console.WriteLine($"Respuesta incorrecta. La respuesta correcta es {respuestaCorrecta.ToUpper()}. {preguntasRespuestas[i, 1]}");
            }
        }

        // Mostrar la puntuación final
        Console.WriteLine("\nPuntuación final: " + score + " de " + preguntasRespuestas.GetLength(0) + " respuestas correctas.");
        Console.WriteLine("¡Gracias por jugar!");
    }
}
