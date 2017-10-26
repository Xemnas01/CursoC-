using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Animal
    {

        public string raza;

        public string Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public Animal()
        {
            this.Raza = "Desconocido";
        }
        //void porque la funcion no devuelve nada
        //se le pone VIRTUAL para que el hijo pueda modificarla con OVERRITE
        //prueba 1 
        /*
        public virtual void ReproducirSonido()
        {
            Console.WriteLine("Sonido desconocido");
        }
        */
        //prueba 2

    public virtual string ReproducirSonido()
    {
        return "Este es el sonido del animal: ";
    }

    }

