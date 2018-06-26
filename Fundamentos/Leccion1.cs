using System;

/**
 * Base de datos
 *
 * SER - Servicio de recaudaciones
 * Sistema de Gestión de Turnos. 
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
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables parte 0");
            Console.WriteLine("*********************************************************");

            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("El valor de i es: " + i);
            Console.WriteLine("El valor de x es: " + x);
            Console.WriteLine("El valor de f es: " + f);
            Console.WriteLine("El valor de d es: " + d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());

            Console.ReadKey();

            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables parte 1");
            Console.WriteLine("*********************************************************");

            int i1 = 10;
            decimal x1 = 12.2m;
            bool bandera1 = true;
            string cadena1 = "12344";
            DateTime fecha1 = DateTime.MinValue;
            i1 = Convert.ToInt32(cadena1);
            Console.WriteLine("El valor de i1 es: {0}", i1);
            Console.WriteLine("El valor de x1 es: {0:C}", x1);
            Console.WriteLine("El valor de bandera1 es: " + bandera1.ToString());
            Console.WriteLine("El valor de cadena1: " + cadena1);
            Console.WriteLine("El valor de fecha1: " + fecha1.ToShortDateString());

            Console.ReadKey();

            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con variables y desicion parte 2");
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

            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con ciclos parte 3");
            Console.WriteLine("*********************************************************");

            Console.WriteLine("Cuantos elementos tendra el vector:");
            string cadena3 = Console.ReadLine();
            int n3 = Convert.ToInt32(cadena3);

            int[] vector = new int[n3];

            for (int c = 0; c < n3; c++)
            {
                Console.Write("Ingrese valor del componente[" + c + "]:");
                String linea;
                linea = Console.ReadLine();
                vector[c] = int.Parse(linea);
            }

            int c1 = 0;
            string mostrar = "[";
            while (c1 < vector.Length)
            {
                if (c1 == vector.Length - 1)
                    mostrar += vector[c1];
                else
                    mostrar += vector[c1] + ",";
                c1++;
            }
            Console.WriteLine("Tu vector es:");
            Console.WriteLine(mostrar + "]");

            Console.ReadKey();

            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con ciclos parte 4");
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
