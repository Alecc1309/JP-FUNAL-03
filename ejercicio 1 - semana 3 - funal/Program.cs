using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1___semana_3___funal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitamos datos al usuario//
            Console.Write("Ingrese el monto del préstamo a otorgar: ");
            double monto = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de cuotas a sacar: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el interés mensual: ");
            double interes = double.Parse(Console.ReadLine()) / 100;

            //Calculamos el valor de la cuota//
            double cuotamensual = (monto + (monto * interes * meses)) / meses;

            //Mostramos el valor de la cuota mensual a pagar//
            Console.Write("El monto mensual a pagar es de: " + cuotamensual);


















        }
    }
}
