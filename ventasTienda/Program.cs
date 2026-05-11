//Una tienda desea registrar las ventas diarias de una semana.
//El programa debe:
//Solicitar al usuario las ventas de cada día.
//Guardar las ventas en un arreglo.
//Calcular el total vendido.
//Mostrar cuántos días las ventas superaron 150.
//Indicar la venta más baja registrada.

        double[] ventas = new double[7];
        double totalVendido = 0;
        int diasSuperaron150 = 0;
        double ventaMasBaja = double.MaxValue;

        for (int i = 0; i < ventas.Length; i++)
        {
            Console.Write($"Ingrese las ventas del día {i + 1}: ");
            ventas[i] = Convert.ToDouble(Console.ReadLine());
            totalVendido += ventas[i];

            if (ventas[i] > 150)
            {
                diasSuperaron150++;
            }

            if (ventas[i] < ventaMasBaja)
            {
                ventaMasBaja = ventas[i];
}
}

Console.WriteLine($"\nTotal vendido en la semana: {totalVendido}");
Console.WriteLine($"Número de días con ventas superiores a 150: {diasSuperaron150}");
Console.WriteLine($"Venta más baja registrada: {ventaMasBaja}");
