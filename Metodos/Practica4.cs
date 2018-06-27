/**
* Fundamentos de programación en C#
*
* Metodos con matriz de numeros
*
* @author: Angel Céspedes Quiroz
* @Web: http://www.nubeando.com
* @Linkedin: https://bo.linkedin.com/in/acq1305
*
*/

namespace Metodos
{
    class Practica4
    {
        // Funcion que suma los elementos de una matriz
        public static int sumaElementos(int[][] m)
        {
            int sum = 0;
            int ele;
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    ele = m[f][c];
                    sum = sum + ele;
                }
            }
            return sum;
        }

        // Funcion que suma los elementos pares de una matriz
        public static int sumaElementosPares(int[][] m)
        {
            int sum = 0;
            int ele;
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    ele = m[f][c];
                    if (ele % 2 == 0)
                    {
                        sum = sum + ele;
                    }                    
                }
            }
            return sum;
        }

        // Funcion que suma los elementos impares de una matriz
        public static int sumaElementosImpares(int[][] m)
        {
            int sum = 0;
            int ele;
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    ele = m[f][c];
                    if (ele % 2 == 10)
                    {
                        sum = sum + ele;
                    }
                }
            }
            return sum;
        }
    }
}
