using System;

/**
 * Fundamentos de programación en C#
 *
 * Declaracion de variables
 *
 * @author: Angel Céspedes Quiroz
 * @Web: http://www.nubeando.com
 * @Linkedin: https://bo.linkedin.com/in/acq1305
 *
 */

namespace Fundamentos
{
    class Leccion2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables parte 2");
            Console.WriteLine("*********************************************************");

            int i1 = 10;
            decimal x1 = 12.2m;
            bool bandera1 = true;
            string cadena1 = "12344";
            i1 = Convert.ToInt32(cadena1);
            Console.WriteLine("El valor de i1 es: {0}", i1);
            Console.WriteLine("El valor de x1 es: {0:C}", x1);
            Console.WriteLine("El valor de bandera1 es: " + bandera1.ToString());
            Console.WriteLine("El valor de cadena1: " + cadena1);

            Console.ReadKey();            
        }
    }
}
