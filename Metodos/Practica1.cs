using System;

/**
* Fundamentos de programación en C#
*
* Funciones y procedimientos
*
* @author: Angel Céspedes Quiroz
* @Web: http://www.nubeando.com
* @Linkedin: https://bo.linkedin.com/in/acq1305
*
*/
namespace Metodos
{
    class Practica1
    {
        // Funcion que suma dos valores
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        // Funcion que resta dos valores
        public static int Restar(int a, int b)
        {
            return a - b;
        }

        // Funcion que multiplica dos valores
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Funcion que divide dos valores
        public static int Dividir(int a, int b)
        {
            return a / b;
        }

        // Funcion que devuelve el residuo de la division de dos valores
        public static int Residuo(int a, int b)
        {
            return a % b;
        }

        // Funcion que valida el operador logico (y) de dos valores
        public static bool And(bool a, bool b)
        {
            return a && b;
        }

        // Funcion que valida el operador logico (o) de dos valores
        public static bool Or(bool a, bool b)
        {
            return a || b;
        }

        // Funcion que concatena la cadena a en la cadena b
        public static string Concatenar(string a, string b)
        {
            return a + b;
        }

        // Procedimiento que muestra un mensaje de hola mundo
        public static void Hola()
        {
            Console.WriteLine("Hola Mundo");
        }

        // Procedimiento que muestra si un numero es impar
        public static void Hola(int n)
        {
            Console.WriteLine("el numero es: "+ (n%2==1));
        }
    }
}
