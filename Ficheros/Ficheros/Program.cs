using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Chema", "Ballestero", 145, Sexo.Hombre, "45542334R");
            Persona p2 = new Persona("Juana", "Trafala", -7, Sexo.Mujer, "67534634F");
            Persona p3 = new Persona("Deivi", "Constantine", 34, Sexo.Hombre, "45542334R");

            //PARA ACCEDER AL ARCHIVO
            try
            {
            // StreamReader fichero = File.OpenText("C:/Users/Tarde/Desktop/Workspace/Ficheros/TextFile1.txt");
            StreamReader fichero = File.OpenText("../../../TextFile1.txt");

            // Console.WriteLine(fichero);
            string linea = "";

            while(linea != null)
            {
                linea = fichero.ReadLine();
                if(linea != null) {
                    Console.WriteLine(linea);
                }
            }
            fichero.Close();

            }catch (Exception e)
        {
            Console.WriteLine("\nfichero no encontrado");
        }

        //PARA ESCRIBIR EN ESE ARCHIVO

        try
        {
            //para escrbir en fichero StreamWriter 
            StreamWriter fichero2 = File.CreateText("../../../TextFile1.txt");
            //texto a escribir en el fichero
            string mensajeNuevo = "\nQue pasa chavales este el mensaje nuevo";
            //para sobreescribir este mensaje a lo que contenga el fichero
            //ESTO BORRA TODO LO QUE CONTENGA EL FICHERO Y LE INTRODUCE LA FRASENUEVA
            fichero2.WriteLine(mensajeNuevo);
            //HAY QUE HACER QUE NO BORRE LO ANTERIOR, SOLO LO AÑADA 
            fichero2.Close();
        }catch (Exception e)
        {
            Console.WriteLine("El fichero no se encuentra");
        }
      

        Console.ReadLine();
        }
    }

