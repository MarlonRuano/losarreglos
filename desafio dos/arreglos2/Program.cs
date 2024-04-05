using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
       
        double[,] montosCompras = {
            {50, 120, 80, 200, 150},  
            {300, 400, 600, 700, 800}, 
            {1000, 900, 1100, 950, 1200}, 
            {90, 80, 70, 60, 50},      
            {2000, 1500, 1800, 2500, 3000} 
        };

        
        for (int i = 0; i < montosCompras.GetLength(0); i++)
        {
            double totalCompras = CalcularTotalCompras(montosCompras, i);
            double descuento = CalcularDescuento(totalCompras);
            Console.WriteLine($"Cliente {i + 1}: Total de compras = {totalCompras}, Descuento aplicado = {descuento}%");
        }

        Console.ReadLine();
    }

    static double CalcularTotalCompras(double[,] montosCompras, int cliente)
    {
        double total = 0;
        for (int j = 0; j < montosCompras.GetLength(1); j++)
        {
            total += montosCompras[cliente, j];
        }
        return total;
    }

    static double CalcularDescuento(double totalCompras)
    {
        if (totalCompras < 100)
        {
            return 0; 
        }
        else if (totalCompras >= 100 && totalCompras <= 1000)
        {
            return 10; 
        }
        else
        {
            return 20; 
        }
    }
}

