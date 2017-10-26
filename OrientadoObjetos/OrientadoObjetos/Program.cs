using System;

//PROGRAMACION ORIENTADA A OBJETOS
namespace OrientadoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea una instancia del tipo Persona (clase) y se le pasan los valores para crear una personaNueva
            Persona personaNueva = new Persona("Chema","Ballestero",15,Sexo.Hombre);

            

            //Accedemos a los valores de la persona a través de los GETTERS creados en la clase 
            Console.WriteLine("Nombre: " + personaNueva.GetNombre() +"\nApellidos: "+personaNueva.GetApellidos()+"\nEdad: "+personaNueva.GetEdad()+"\nSexo: "+personaNueva.GetSexo());

            //Otra forma de imprimirlo moficando el metodo ToString() de a case padre;
            Console.WriteLine("\n"+personaNueva);


            //Prueba de modificación con SETTERS
            personaNueva.SetNombre("Troloskaspo");
            Console.WriteLine("\n" + personaNueva);

            //Utilizando GetNombreCompleto() que es un metodo derivado
            Console.WriteLine(personaNueva.GetNombreCompleto());

            //utilizando la clase por defecto
            Persona p2 = new Persona("Chema","",25,Sexo.Hombre);
            Console.WriteLine();

            //Creando un ciudadano a partir de la clase persona y ciudadanos que extiende de la anterior
            Ciudadanos c1 = new Ciudadanos("Juanjo","Caranjo",63,Sexo.Hombre, "53769846D");


            //EJERCICIOS PAG 44 1,2,3

            PixelConHe nuePi = new PixelConHe(0.524f, 0.23f, "amarillo");
            PixelSinHe nuePi2 = new PixelSinHe();

            Console.WriteLine(nuePi2.GetX());
            Console.WriteLine(nuePi.GetColor());

            nuePi.SetX(0.24345f);
            Console.WriteLine(nuePi.GetX());


            Console.ReadLine();
        }
    }
}
