using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program 
{
    static void Main(string[] args)
    {
        //INICIALIZAR EVENTOS
        Evento even1 = new Evento();
        Evento even2 = new Evento("Ludico", 5, "CASA");

        Evento even3 = new Evento();
        Evento even4 = new Evento("Parpoa", 64, "biblioteca");

        //GUARDAR EVENTOS EN ARRAY 
        Evento[] estudios1 = new Evento[] {even2};
        Evento[] experiencia1 = new Evento[] {even4};

        //CANDIDATOS
        Candidato cand1 = new Candidato();
        //el curriculum se pone a null ya que aun no se puede crear ya que candidato no es modificabe (no existe SetCandidato())
        //y e curriculum si se puede modificar con SetCV();
        Candidato cand2 = new Candidato("Manu", "Caja", 76, Sexo.Hombre, "8765879D", "Administrativa", null, 76);

        //CV creamos curriculum el cual añadiremos en el candidato
        CV curri = new CV();
        CV curri2 = new CV(estudios1,experiencia1,cand2);
        //editamos el curriculum de cand2 para introducir el curriculum creado (curri2) dentro del campo CV que habiamos puesto en null
        cand2.SetCV(curri2);
       

        //Prueba Personas rellena
        Persona p1 = new Persona("Chema", "Ballestero", 64, Sexo.Hombre, "53769846D");
        //sin parametros
        Persona p2 = new Persona();
        //con fallo en la edad 
        Persona falloEdad = new Persona("Chema", "Ballestero", -64, Sexo.Hombre, "53769846D");

        Console.WriteLine(p1.ToString() + "\n");

        Console.WriteLine(p2.ToString() + "\n");

        Console.WriteLine("Con fallo en la edad \n" + falloEdad);

        //impresion candidatos 
        Console.WriteLine("\nCandidato\n"+cand2);

        //EJEMPLO CON SPLIT  se mueve a la clase persona y se crea un constructor
        Console.WriteLine("\nEjemplo con Split");

        string PersonaBruto = "JUANCA,LAVAO,85,0,4567893R";
        string[] PersonaSplit = PersonaBruto.Split(',');

        string nombre = PersonaSplit[0];
        string apellidos = PersonaSplit[1];
        int edad = int.Parse(PersonaSplit[2]);
        //Se hace asi para pasar el sexo a int y que coja el enumerado por defecto
        Sexo sexo = (Sexo)(int.Parse(PersonaSplit[3]));
        string dni = PersonaSplit[4];


        //p3 se muestra gracias al nuevo constructor con split en la clase Persona
        Persona p3 = new Persona("PASODO,EIREO,56,1,5335672R");

        Console.WriteLine(p3);

        string frase = "saramambiche";
        //para pasar tdo a minusculas
        frase = frase.ToLower();
        //frase para remplazar un caracter por otro
        //en este caso vamos a reemplazar las a por t
        frase = frase.Replace("a", "t");
        Console.WriteLine(frase);

        //PAra limpiar codigo que se muestra
        string personaBruta = " Fernando, Garcia, 21 ,0";
        Console.WriteLine(personaBruta);
        //reemplazamos el espacio para quitarlo
        personaBruta = personaBruta.Replace(" ","");
        Console.WriteLine(personaBruta);

        //PARA CREAR UNA PERSONA DESDE TECLADO DIRECTAMENTE ---> constructor
        /* Console.WriteLine("\nIntroduce los datos de la persona (nombre,apellidos,edad,sexo,dni)");
         Persona pruebaPersona = new Persona (Console.ReadLine());
         Console.WriteLine(pruebaPersona);*/

        //---------------------------------------------------------------------------------------------------------------


        //iniciarlo todo introduciendo dede teclado
      /*  string eventoEstudios = "ESO,42,IES Cavaleri";
        string eventoLaboral = "Tecnico,6,ayuntamiento";

        string persona = "Juan,Belmonte,54,1,23345224R";
        string candidato = "Juan,Belmonte,54,1,23345224R,Programador";
        */
        
        
        //prueba candidato split
        Console.WriteLine("\nCANDIDATO POR SPLIT");
        Console.WriteLine("\nIntroduzca datos nuevo candidato formato (nombre,apellido,edad,sexo,dni,puesto,null,valoracion)");
        Candidato c2 = new Candidato(Console.ReadLine());

        //Recoger eventos por consola
        // Console.WriteLine("\nEVENTO POR SPLIT");
        Console.WriteLine("\nIntroduzca datos estudios formato (nombre,tiempo,lugar)");
        Evento eventoEstu = new Evento(Console.ReadLine());
        // Console.WriteLine(eventoEstu);

        Console.WriteLine("\nIntroduzca datos nueva experiencia formato (nombre,tiempo,lugar)");
        Evento eventoExpe = new Evento(Console.ReadLine());
        // Console.WriteLine(eventoExpe);

        //ARRAYEVENTOSPRUEEBA
        Evento[] estu1 = new Evento[] { eventoEstu };
        Evento[] expe1 = new Evento[] { eventoExpe };

        //Creo un curriculum 
        CV curri3 = new CV(estu1, expe1, c2);

        c2.SetCV(curri3);




        Console.WriteLine(c2);

        Console.ReadLine();
    }
}

