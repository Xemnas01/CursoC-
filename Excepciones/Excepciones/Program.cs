using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //EJEMPLO
            //Se puede crear almacenando la excepcion en una variable
            DivideByZeroException e;
            //O sacarla directamente
           // throw new DivideByZeroException ("Se ha introducido una edad igual a cero");

            // TRY / CATCH

            //para recoger un numero por teclado directamente
            Console.WriteLine("Introduzca numero");
            int numero = int.Parse(Console.ReadLine());
            Console.ReadLine();

            try
            {
                int resultado = 1 / numero;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("El numero nitroducido no puede ser 0");
                

            }

            //FORM para sacarpor pantalla
            string nombre = "TROwo";
            int edad = 5;

            Console.WriteLine("Mi nombre es "+nombre+" y mi edad es "+edad);
            //para sacarpor pantalla mas facil
            Console.WriteLine(string.Format("Mi nombre es {0} y mi edad es {1}",nombre,edad));
            //split

            string personaBruto = "Perico,El de los Palotes,53,543456R";
            string[] personaSplit = personaBruto.Split(',');
            Console.WriteLine(personaSplit);
            Console.ReadLine();
        }
    }
}
