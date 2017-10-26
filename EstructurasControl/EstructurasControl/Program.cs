using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //EJERCICIOS IF/ELSE 

            //pag 30 - 1 (comprobar si i esta comprendido en elrango [a,b]            
            Console.WriteLine("Introduzca valor de i ");
            string valori = Console.ReadLine();
            Console.WriteLine("Introduzca valor de a ");
            string valora = Console.ReadLine();
            Console.WriteLine("Introduzca valor de b ");
            string valorb = Console.ReadLine();
            int i = int.Parse(valori);
            int a = int.Parse(valora);
            int b = int.Parse(valorb);

            //si i es mayor o igual que a y ademas i es menor o igual que b, i esta en el rango (para el rango de 0 - 999)
            if (i >= a && i <= b)
            {

                Console.WriteLine("El numero " + i + " esta comprendido entre " + a + " y " + b);
            }
            else if(i >= b && i <= a) //si i es menor o igual que a y ademas i es mayor o igual que b, i esta en el rango (para el rango de 999 - 0)
            {
                Console.WriteLine("El numero " + i + " esta comprendido entre " + a + " y " + b);
            }
            else //si no se cumplen las condiciones esta fuera del rango
            {
                Console.WriteLine("El numero " + i + " no esta comprendido entre " + a + " y " + b);
            }
            */
            //pag 30 - 2


            /*
            //WHILE 

            Console.WriteLine("Introduzca valor de i ");
            string valori2 = Console.ReadLine();
            Console.WriteLine("Introduzca valor de a ");
            string valora2 = Console.ReadLine();
            Console.WriteLine("Introduzca valor de b ");
            string valorb2 = Console.ReadLine();
            int i2 = int.Parse(valori2);
            int a2 = int.Parse(valora2);
            int b2 = int.Parse(valorb2);

            bool incorrecto = false;

           

            //para comprobar que el valor introducido de a es mayor que el valor de b
            if (a2 <= b2)
            {
                incorrecto = false;
                if (i2 >= a2 && i2 <= b2)
                {

                    Console.WriteLine("El numero " + i2 + " esta comprendido entre " + a2 + " y " + b2);
                }
                else //si no se cumplen las condiciones esta fuera del rango
                {
                    Console.WriteLine("El numero " + i2 + " no esta comprendido entre " + a2 + " y " + b2);
                }
            }
            else
            {
                incorrecto = true;
                
                //WHILE para controlar que mientras que no se introduzcan los valores correctamente lo pida hasta que sea correcto
                while (incorrecto)
                {
                    Console.WriteLine("El numero " + a2 + " debe ser mayor que " + b2);
                    Console.WriteLine("Introduzca valor de a2 ");
                    valora2 = Console.ReadLine();
                    a2 = int.Parse(valora2);
                    Console.WriteLine("Introduzca valor de b2 ");
                    valorb2 = Console.ReadLine();
                    b2 = int.Parse(valorb2);
                   

                }


            }
            */

            /*
            //SWITCH

            //pag 30 - 3
            Console.WriteLine("Introduzca palabra");
            string mensaje = Console.ReadLine();

            //para pasar el mensaje a minusculas y que no de fallos si se introducen alguna mayuscula
            mensaje = mensaje.ToLower();
            //respuesta en blanco ya que segun cada caso llevara una diferente
            string respuesta = "";

            switch (mensaje)
            {
                case "si":
                    respuesta = "Afirmativo";
                    Console.WriteLine(respuesta);
                    break;
                case "no":
                    respuesta = "Negativo";
                    Console.WriteLine(respuesta);
                    break;
                default:
                    respuesta = "Desconocido";
                    Console.WriteLine(respuesta);
                    break;

            }


    */

            //FOREACH

            //pag30 - 5

            
            int[] enteros = new int[] { 3, 40, 567, -23, -457, 52, 68,54,-250};

            //version foreach
            Console.WriteLine("FOR EXTENDIDO O FOREACH");
            //enteros es una coleccion creada como un array. 
            foreach (int n in enteros)
            {
                // % --> es para saber el resto de la division, por lo que si el resto al dividir entre 2 es 0 significa que es par
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
            }

            //version for clasico
            Console.WriteLine("FOR CLASICO");
            int[] pares = new int[9];
            for (int i = 0;  i < enteros.Length; i++)
            {
                // % --> es para saber el resto de la division, por lo que si el resto al dividir entre 2 es 0 significa que es par
                if (enteros[i]%2 == 0)
                {
                    pares[i] = enteros[i];
                    Console.WriteLine(enteros[i]);
                }
            }

     
            
            



            Console.ReadLine();
        }
    }
}
