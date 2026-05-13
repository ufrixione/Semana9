double[,] matriz = new double[3, 3];

Console.WriteLine("Matrices");
Console.WriteLine("Ingresa las temperaturas");
for(int r = 0; r < 3; r++)
{

    for(int c = 0; c<3 ; c++)
    {
        try
        {
            Console.WriteLine($"Dime la temperatura # {c + 1}");
            matriz[r, c] = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            c--; // Decrementar el índice para volver a solicitar la entrada
            Console.ResetColor();
            }
    }
}
Console.Clear();
Console.WriteLine("Temperaturas Registradas");
for(int f = 0; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        if(matriz[f, c] < 35) Console.ForegroundColor = ConsoleColor.Green;
        else if (matriz[f, c] >= 35 && matriz[f, c] <= 40) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {matriz[f, c]} ");
        Console.ResetColor();
    }
    Console.WriteLine();
}
