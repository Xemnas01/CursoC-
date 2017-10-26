using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasArray
{
    class Program
    {
        //EJERCICIOS ENUMERADOS

        //Pagina 17 - 1 **** (mas abajo)
        enum frutas
        {
            Pera,
            Banana,
            Melocotón,
            Chirimoia,
            Kiwi
        }
        //Pagina 17 - 2
        enum diasSemana
        {
            Lunes = 0,
            Martes = 1,
            Miercoles = 2,
            Jueves = 3,
            Viernes = 4,
            Sabado = 5,
            Domingo= 6
        }

        static void Main(string[] args)
        {
            /*
             
            ctrl+k+d formateado del docigo entero

            string nombre = Console.ReadLine();
            nombre = nombre + " 1";
            Console.WriteLine(nombre);

            //Para hacer el cast de forma implicita (se hacepor defecto)
            string a = Console.ReadLine();
            int valorA = int.Parse(a);
            double valorAD = valorA;

            //Para hacer el cast de forma explicita (tienes que especificar a que tipo se cambia)
            string b = Console.ReadLine();
            int valorb = int.Parse(b);
            double valorBD = (double)valorb;
            */

            //EJERCICIOS ENUMERADOS

            //Pagina 17 - 1 ***

            /*
            const frutas frutaBuena = frutas.Banana;
            Console.WriteLine("El unico fruto del amor es la " + frutaBuena);

            //Pagina 17 - 3
            Console.WriteLine("Inserte numero");
            string numeroA = Console.ReadLine();
            //hacemos el parse para pasar el numero introducido de tipo strng a tipo int
            int numero = int.Parse(numeroA);
            //cambiamos el tipo int de numero a tipo diasSemana(enum)
            diasSemana prueba = (diasSemana)numero;
            Console.WriteLine("El dia de la semana elegido es " + prueba);
            */

            //EJERCICIOS ARRAYS
            
            //pag 20 - 1
             string[] diasSemana = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes","Sabado","Domingo" };
            //bucle for para que muestre todos los elementos del array
            for(int i = 0; i <= diasSemana.Length - 1; i++) {
                Console.WriteLine(diasSemana[i]);
            }
       

            //pag 20 - 2
            diasSemana = new string[] {"Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado" };
            //bucle for para que muestre todos los elementos del array
            for (int i = 0; i <= diasSemana.Length - 1; i++)
            {
                Console.WriteLine(diasSemana[i]);
            }
            /* tambien se pueden sacar por pantalla de la siguiente manera
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[1]);
            Console.WriteLine(diasSemana[2]);
            Console.WriteLine(diasSemana[3]);
            Console.WriteLine(diasSemana[4]);
            Console.WriteLine(diasSemana[5]);
            Console.WriteLine(diasSemana[6]);
            */

            //pag 20 - 3
            //el atributo .Length se utiliza para saber la longitud completa del array 
            int longitudArray = diasSemana.Length;
            Console.WriteLine("El longitud del array es "+longitudArray);

            //Console.WriteLine(diasSemana[14]); //System.IndexOutOfRangeException: Indice fuerfa de los limites de la matriz


            Console.ReadLine();

        }
    }
}
