using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTAS 

            //Creo algunos objetos tipo persona
            Persona p1 = new Persona("Pepe", "Palotes", 54, Sexo.Hombre, "45774454G");
            Persona p2 = new Persona("Juan", "palomo", 32, Sexo.Hombre, "23534756G");
            Persona p3 = new Persona("Benito", "Camela", 76, Sexo.Hombre, "5477654T");

            //declaro una lista de tipo Persona 
            List<Persona> personas = new List<Persona>();

            //añado a la lista las personas 
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);

            //para que me muestre por pantalla las personas
            foreach (Persona p in personas)
            {
                Console.WriteLine(p+"\n");
            }

            //DICCIONARIOS 

            //Creamos diccionario string (porque el dni es de tipo string) y Persona (a las cuales se ascia el dni)
            Dictionary <string, Persona> personaPorDNI = new Dictionary<string, Persona>();
            //añadimos al diccionario asociando cada dni con la persona
            //se pone p1.DNI porque accedemos al metodo que devuelve el dni de esa persona
            personaPorDNI.Add(p1.DNI, p1);
            personaPorDNI.Add(p2.DNI, p2);
            personaPorDNI.Add(p3.DNI, p3);


            //Para buscar a una persona mediante su dni         
            //Se solicita la introduccion de un dni
            Console.WriteLine("Introduce un DNI: " );
            string dni = Console.ReadLine();
            //que muestre la persona cuyo dni coincida con el introducido
            Console.WriteLine("\n"+personaPorDNI[dni]);

            Console.ReadLine();
        }
    }
}
