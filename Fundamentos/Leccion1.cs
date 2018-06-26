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
    class Leccion1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables parte 1");
            Console.WriteLine("*********************************************************");

            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola mundo";
            bool bandera = false;
            Console.WriteLine("El valor de i es: " + i);
            Console.WriteLine("El valor de x es: " + x);
            Console.WriteLine("El valor de f es: " + f);
            Console.WriteLine("El valor de d es: " + d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());

            Console.ReadKey();            
        }
    }
}
