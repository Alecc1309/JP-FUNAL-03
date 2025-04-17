using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3___semana_3___funal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitamos los datos//
            Console.Write("Ingrese el nombre del trabajador: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa el número de horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            double pagoxhora = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de retención: ");
            double porcentaje = Convert.ToDouble(Console.ReadLine()) / 100;

            //Calculamos el salario//
            double sueldobruto = horas * pagoxhora;
            double descuento = sueldobruto * porcentaje;
            double sueldoneto = sueldobruto - descuento;

            //Mostramos los resultados//
            Console.Write("Resumen del pago para: " + nombre);
            Console.WriteLine("Su sueldo bruto es de: " + sueldobruto);
            Console.WriteLine("El total descontado es de: " + descuento);
            Console.WriteLine("Y su sueldo neto es de: " + sueldoneto);












        }
    }
}
