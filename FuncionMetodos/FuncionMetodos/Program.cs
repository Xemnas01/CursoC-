using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionMetodos
{
    //FUNCIONES/METODOS | tipo Nombre (parametrosEntrada){codigo de la funcion}
    class Program
    {
        /*
         * EJEMPLO
        static void Imprime(string p)
        {
            Console.WriteLine(p);
        }

        static double sumaDouble (string a,string b)
        {
            double val1 = double.Parse(a);
            double val2 = double.Parse(b);

            return val1+val2;
        }
        static int sumaEnteros (int a, int b)
        {
            return a + b;

        }
        
             */


        //pag 35 - 3

        static double valorPorcentual(string n)
        {
            //pasaamos a tipo entero el string pasado en el metodo
            int val = int.Parse(n);
            //iniciamos la variable double la cual permite los decimales
            double valPorcen = val;

            //Para controlar que muestre el numero comprendido entre 0 y 1 
            //comprobamos que el valor sea mayor o igual que cero y estrictamente menor a 100
            if (val >= 0 && val < 100)
            {
                //almacenamos en la variable tipo double el valor del numero pasado a metodo dividido entre 100 para conseguir el mismo numero entre 0 y 1
                valPorcen = val / 100f;
                //siempre hay que devolver un valor.
                return valPorcen;
            }
            else
            {
                //si el numero no es mayor o igual k 0 o el numero es 100
                valPorcen = 1;
                return valPorcen;
            }
            
        }


        static void Main(string[] args)
        {
            /* 
             EJEMPLO 
            Console.WriteLine("Introduce palabra");
            string palabra = Console.ReadLine();
            Imprime(palabra);

            Console.WriteLine("Introduce numero 1 ");
            string num1 = Console.ReadLine();
            
            Console.WriteLine("Introduce numero 2 ");
            string num2 = Console.ReadLine();
            
            double sumaTotal = sumaDouble(num1,num2);
            Console.WriteLine(sumaTotal);

            */

            //pag 35 -5

            Console.WriteLine("Introduce un numero entero del 0 al 100");
            string numero = Console.ReadLine();

            //Para imprimir por pantalla llamamos a la funcion WriteLine pasandole la funcion con el valor introducido por teclado
            Console.WriteLine(valorPorcentual(numero));



            Console.ReadLine();
        }
    }
}
