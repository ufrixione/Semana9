double[] temperaturas = new double[7];
try
{
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine($"Ingrese la temperatura del día {i + 1}:");
        temperaturas[i] = double.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Por favor, ingresa un número válido para la temperatura.");
}
Console.WriteLine($"Las temperaturas ingresadas son: {string.Join(", ", temperaturas)}");
Console.WriteLine($"La temperatura promedio semanal es: {temperaturas.Average()}");
Console.WriteLine($"La temperatura máxima semanal es: {temperaturas.Max()}");
Console.WriteLine($"La temperatura mínima semanal es: {temperaturas.Min()}");
