/*Ejercicio 1:
Capturar 3 notas, sacar el Promedio y determinar si el estudiante ganó o perdió la asignatura 
(Mayor o igual a 3 ganó en caso contrario Perdió) */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class calcularNotasPromedio
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, sum, prom;
            Console.WriteLine("DIGITE PRIMERA NOTA:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE SEGUNDA NOTA:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE TERCERA NOTA:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            sum = nota1 + nota2 + nota3;
            prom = sum / 3;

            Console.WriteLine("EL PROMEDIO ES: " + prom);

            if (prom < 3)
            {
                Console.WriteLine("PERDIO EL CORTE");
            }
            else
                Console.WriteLine("GANO EL CORTE");
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}