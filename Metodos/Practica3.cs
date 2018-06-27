/**
* Fundamentos de programación en C#
*
* Metodos con vector de numeros
*
* @author: Angel Céspedes Quiroz
* @Web: http://www.nubeando.com
* @Linkedin: https://bo.linkedin.com/in/acq1305
*
*/

namespace Metodos
{
    class Practica3
    {
        // Funcion que devuelve la suma de los elementos de un vector
        public static int sumaElementos(int[] v)
        {            
            int sum = 0;
            int ele;
            for(int i= 0; i < v.Length; i++)
            {
                ele= v[i];
                sum = sum + ele; 
            }
            return sum;
        }

        // Funcion que devuelve la suma de los elementos pares de un vector
        public static int sumaElementosPares(int[] v)
        {
            int sum = 0;
            int ele;
            for (int i = 0; i < v.Length; i++)
            {
                ele = v[i];
                if (ele % 2 == 0)
                {
                    sum = sum + ele;
                }                
            }
            return sum;
        }

        // Funcion que devuelve la suma de los elementos impares de un vector
        public static int sumaElementosImpares(int[] v)
        {
            int sum = 0;
            int ele;
            for (int i = 0; i < v.Length; i++)
            {
                ele = v[i];
                if (ele % 2 == 1)
                {
                    sum = sum + ele;
                }
            }
            return sum;
        }
    }
}
