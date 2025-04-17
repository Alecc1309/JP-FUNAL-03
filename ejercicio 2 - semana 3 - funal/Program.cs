using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2___semana_3___funal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitamos el monto a cambiar//
            Console.Write("Ingrese el monto en dólares a cambiar: ");
            double dolar = double.Parse(Console.ReadLine());

            //Realizamos el tipo de cambio//
            double euro = dolar * 0.93;
            double pesomex = dolar * 17.5;
            double sol = dolar * 3.8;

            //Mostramos el cambio de las monedas//
            Console.Write("Su monto en dolares convertidos a euroes es de: " + euro);
            Console.Write(", A pesos mexicanos es de: " + pesomex);
            Console.Write(" Y a soles es de: " + sol);














        }
    }
}
