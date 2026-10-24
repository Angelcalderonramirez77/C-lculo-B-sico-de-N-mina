using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CálculoBásicoNómina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Nombre del empleado
            Horas trabajadas
            Pago por hora
            Debe calcular:
            Salario bruto = Horas trabajadas × Pago por hora  
            Finalmente, deberá mostrar un resumen organizado con los datos del empleado y el salario calculado.
             */

            string nombre = string.Empty;
            float horasTrabajo = 0;
            float pagoHoras = 0;
            float salarioBruto = 0;


            Console.Write("Ingrese el nombre de empleado: ");
            nombre = Console.ReadLine().ToUpper();

            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            if (! float.TryParse(Console.ReadLine(), out horasTrabajo))
            {
                Console.WriteLine("Error: Debe ingresar un número válido para las horas trabajadas.");
                return;
            }

            Console.Write("Ingrese el valor de las horas : ");
            if (!float.TryParse(Console.ReadLine(), out pagoHoras))
            {
                Console.WriteLine("Error: Debe ingresar un número válido del valor de la hora trabajada.");
                return;
            }

            salarioBruto = (horasTrabajo * pagoHoras);

                    
            Console.WriteLine("\nResumen del empleado: ");
            Console.WriteLine($" Empleado {nombre} ");
            Console.WriteLine($" las horas que trabajo {horasTrabajo} ");
            Console.WriteLine($" las horas que trabajo {horasTrabajo} ");
            Console.WriteLine($" una hora vale {pagoHoras} ");
            Console.WriteLine($" El sueldo optenido es de  RD:{salarioBruto:N2} ");



        }
    }
}
