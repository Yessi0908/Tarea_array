using System;
class desafio
{
    static void Main(string[] args)
    {
        double[,] com = new double[5, 5]
        {
            { 100, 150, 200, 250, 275 },
            { 300, 350, 400, 450, 700 },
            { 750, 800, 850, 900, 1200 },
            { 1250, 1300, 1350, 1400, 1500 },
            { 1850, 1950, 2500, 2600, 2800 }
        };
        Descuentos(com);
    }
    static void Descuentos(double[,] com)
    {
        for (int i = 0; i < com.GetLength(0); i++)
        {
            double total = 0;
            for (int j = 0; j < com.GetLength(1); j++)
            {
                total += com[i, j];
            }
            double descuento = 0;
            if (total > 1000)
            {
                descuento = total * 0.20;
            }
            else if (total > 100)
            {
                descuento = total * 0.10;
            }
            double totalConDescuento = total - descuento;
            Console.WriteLine($"Cliente {i + 1}: Compra = {total}, Descuento = {descuento}, Total = {totalConDescuento}");
        }
    }
}