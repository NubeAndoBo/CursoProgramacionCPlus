using System;

/**
 * Fundamentos de programación en C#
 *
 * Ciclos y matrices
 *
 * @author: Angel Céspedes Quiroz
 * @Web: http://www.nubeando.com
 * @Linkedin: https://bo.linkedin.com/in/acq1305
 *
 */

namespace Fundamentos
{
    class Practica5
    {
        public static void Ejecutar()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con ciclos parte 5");
            Console.WriteLine("*********************************************************");

            int[,] mat4;

            Console.WriteLine("Cuantas filas tendra la matriz:");
            string cadena4 = Console.ReadLine();
            int fila4 = Convert.ToInt32(cadena4);

            Console.WriteLine("Cuantos columnas tendra la matriz:");
            string cadena5 = Console.ReadLine();
            int columna4 = Convert.ToInt32(cadena5);

            mat4 = new int[fila4, columna4];
            for (int f4 = 0; f4 < fila4; f4++)
            {
                for (int c4 = 0; c4 < columna4; c4++)
                {
                    Console.Write("Ingrese posicion [" + (f4 + 1) + "," + (c4 + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat4[f4, c4] = int.Parse(linea);
                }
            }

            for (int f5 = 0; f5 < fila4; f5++)
            {
                for (int c5 = 0; c5 < columna4; c5++)
                {
                    Console.Write(mat4[f5, c5] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
