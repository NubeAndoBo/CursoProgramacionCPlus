using System;

/**
 * Fundamentos de programación en C#
 *
 * Ciclos y vectores
 *
 * @author: Angel Céspedes Quiroz
 * @Web: http://www.nubeando.com
 * @Linkedin: https://bo.linkedin.com/in/acq1305
 *
 */

namespace Fundamentos
{
    class Leccion4
    {
        public static void Ejecutar()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("probando con ciclos parte 4");
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
        }
    }
}
