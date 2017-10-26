using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// En las clases perro y animal esta  LA EXPLICACION DE OVERRIDE Y VIRTUAL para omdificar funciones de clases padres en la clase hija
    class Program
    {
        static void Main(string[] args)
        {
        /*
            //Comprobacion funcionamiento EQUALS

            //creo 3 objetos nuevos de Tipo personas de los cuales 2 tienen el mismo dni
            Persona p1 = new Persona("Chema", "Ballestero", 145, Sexo.Hombre, "45542334R");
            Persona p2 = new Persona("Juana", "Trafala", -7, Sexo.Mujer, "67534634F");
            Persona p3 = new Persona("Deivi", "Constantine", 34, Sexo.Hombre, "45542334R");

            //muestro los 3 por pantalla
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            //uso objeto1.Equals(objetoACompararConObjeto1);
            //Equals compara los dni (se suponen que son unicos) por lo que 1 y 2 son diferentes y 1 y 3 son iguales
            Console.WriteLine("Son iguales p1 y p2?: "+p1.Equals(p2));
            Console.WriteLine("Son iguales p1 y p3?: " + p1.Equals(p3));
        */

        //pruebas virtual y override    
        //1
        Animal animal1 = new Animal();
        Perro perro1 = new Perro();

        animal1.ReproducirSonido();//Desconocido
        perro1.ReproducirSonido();//guau

        //2
        //creamos un string donde se almacena la frase recibida de las funciones ReproducirSonido
        //Cuando es un animal
        string frase = animal1.ReproducirSonido();
        Console.WriteLine(frase);
        //Cuando es un perro
        frase = perro1.ReproducirSonido();
        Console.WriteLine(frase);

            Console.ReadLine();
        }
    }

