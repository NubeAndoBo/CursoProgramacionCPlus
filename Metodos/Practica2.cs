/**
* Fundamentos de programación en C#
*
* Metodos con digitos
*
* @author: Angel Céspedes Quiroz
* @Web: http://www.nubeando.com
* @Linkedin: https://bo.linkedin.com/in/acq1305
*
*/

namespace Metodos
{
    class Practica2
    {
        // Funcion que devuelve la suma de los digitos de un numero
        public static int sumaDig(int n)
        {
            int sum = 0;
            int dig;
            while (n > 0)
            {
                dig = n % 10;
                sum = sum + dig;
                n = n / 10;
            }
            return sum;
        }

        // Funcion que devuelve la suma de los digitos pares de un numero
        public static int sumaDigPares(int n)
        {
            int sum = 0;
            int dig;
            while (n > 0)
            {
                dig = n % 10;
                if (dig % 2 == 0)
                {
                    sum = sum + dig;
                }                
                n = n / 10;
            }
            return sum;
        }

        // Funcion que devuelve la suma de los digitos impares de un numero
        public static int sumaDigImpares(int n)
        {
            int sum = 0;
            int dig;
            while (n > 0)
            {
                dig = n % 10;
                if (dig % 2 == 1)
                {
                    sum = sum + dig;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
