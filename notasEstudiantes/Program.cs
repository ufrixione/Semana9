/*Un profesor necesita almacenar las calificaciones finales de sus estudiantes.

El programa debe:
Solicitar las notas de 8 estudiantes.
Guardar las notas en un arreglo unidimensional.
Mostrar únicamente las notas aprobadas.
Contar cuántos estudiantes reprobaron.
Calcular el promedio general del grupo.*/
        const int numEstudiantes = 8;
        double[] calificaciones = new double[numEstudiantes];
        int contadorReprobados = 0;
        double sumaCalificaciones = 0;

        // Solicitar las notas de los estudiantes
        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.Write($"Ingrese la calificación del estudiante {i + 1}: ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            sumaCalificaciones += calificaciones[i];

            if (calificaciones[i] < 60)
            {
                contadorReprobados++;
            }
        }

        // Mostrar únicamente las notas aprobadas
        Console.WriteLine("\nCalificaciones aprobadas:");
        for (int i = 0; i < numEstudiantes; i++)
        {
            if (calificaciones[i] >= 60)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }
        }

        // Contar cuántos estudiantes reprobaron
        Console.WriteLine($"\nNúmero de estudiantes reprobados: {contadorReprobados}");

        // Calcular el promedio general del grupo
        double promedio = sumaCalificaciones / numEstudiantes;
        Console.WriteLine($"Promedio general del grupo: {promedio:F2}");