using System;

/**
 * Fundamentos de programación en C#
 *
 * Declaracion de variables y manejo de condicion
 *
 * @author: Angel Céspedes Quiroz
 * @Web: http://www.nubeando.com
 * @Linkedin: https://bo.linkedin.com/in/acq1305
 *
 */

namespace Fundamentos
{
    class Practica3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables y desicion parte 3");
            Console.WriteLine("*********************************************************");

            int valor2 = 0, valor3 = 0;
            string cadena2;
            Console.WriteLine("Dame el valor2:");
            cadena2 = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena2);
            Console.WriteLine("Dame el valor3:");
            cadena2 = Console.ReadLine();
            valor3 = Convert.ToInt32(cadena2);
            if (valor2 <= valor3) // condicion
            {
                if (valor2 == valor3)
                    Console.WriteLine("El valor 2 es igual al valor 3");
                else
                    Console.WriteLine("El valor 3 es mayor al valor 2");
            }
            else
                Console.WriteLine("El valor 2 es mayor que el valor 3");

            Console.ReadKey();            
        }                                          
    }
}
