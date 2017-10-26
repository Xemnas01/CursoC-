using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // cw  dos veces tab para un Console.WriteLine(); directamente
            // ctrl+k+c para comentar toda la linea 
            // ctrls+k+u para descomentar la linea
            // para mantener la ventana de comandos: Console.ReadLine();

            string mundo = "Hola Mundo";
            Console.WriteLine(mundo);

            //Para recoger por teclado Console.ReadLine();
            string prueba = Console.ReadLine();

            //Para mostrar en pantalla 
            Console.WriteLine(prueba);

            //Para recoger un numero por teclado:
            //1º creamos un string al cual el numero se le introduzca desde teclado
            //con la funcion Parse(); cambiamos al tipo que queramos, ej: int.Parse(objetoCambioDeTipo);

            //Prueba suma operaciones con Parse();
            Console.WriteLine("Introduzca valor de A ");
            string a = Console.ReadLine();
            //int.Parse(a) para cambiar el tipo string de a a tipo int
            int valorA = int.Parse(a);

            Console.WriteLine("Introduzca valor de B ");
            string b = Console.ReadLine();
            int valorB = int.Parse(b);
            int suma = valorA + valorB;
            Console.WriteLine("La suma de "+valorA+" mas a suma de "+valorB+" es igual a "+suma);

            //Ejemplo con valores decimales
            Console.WriteLine("Introduzca valor de d ");
            string d = Console.ReadLine();
            double valorD = double.Parse(d);
            Console.WriteLine("Introduzca valor de s ");
            string s = Console.ReadLine();
            double valorS = double.Parse(s);

            double sumaD = valorD + valorS;
            Console.WriteLine("La suma de " + valorD + " mas a suma de " + valorS + " es igual a " + sumaD);

            //Para que no se cierre la ventana de comandos
            Console.ReadLine();
            
        }
    }
}
