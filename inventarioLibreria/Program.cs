/*Una librería necesita registrar las ventas de libros por categoría.
El programa debe:
Solicitar la cantidad de libros vendidos en 5 categorías.
Guardar la información en un arreglo.
Mostrar el total de libros vendidos.
Indicar la categoría con más ventas.
Calcular el promedio de ventas.*/

        int[] ventas = new int[5];
        string[] categorias = { "Ficción", "No Ficción", "Ciencia", "Historia", "Infantil" };
        int totalVentas = 0;
        int categoriaMasVendida = 0;

        // Solicitar la cantidad de libros vendidos en cada categoría
        for (int i = 0; i < ventas.Length; i++)
        {
            Console.Write($"Ingrese la cantidad de libros vendidos en la categoría {categorias[i]}: ");
            ventas[i] = int.Parse(Console.ReadLine());
            totalVentas += ventas[i];

            // Verificar si esta categoría tiene más ventas que la actual categoría más vendida
            if (ventas[i] > ventas[categoriaMasVendida])
            {
                categoriaMasVendida = i;
            }
        }

        // Mostrar el total de libros vendidos
        Console.WriteLine($"\nTotal de libros vendidos: {totalVentas}");

        // Indicar la categoría con más ventas
        Console.WriteLine($"La categoría con más ventas es: {categorias[categoriaMasVendida]} con {ventas[categoriaMasVendida]} ventas.");

        // Calcular el promedio de ventas
        double promedioVentas = (double)totalVentas / ventas.Length;
        Console.WriteLine($"El promedio de ventas por categoría es: {promedioVentas:F2}");