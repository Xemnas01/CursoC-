using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RepasoFicheros
{
    //LEER UN FICHERO 
    #region LeerFichero
    private static string LeerFichero(string ruta)
    {
        string texto = "";
        //SIEMPRE UN TRY CATCH PARA CAPTURAR ERRORES CON EL ACCESO AL FICHERO
        try
        {
            //STREAMREADER PARA LEER UN FICHERO
            StreamReader fichero = File.OpenText(ruta);
            //se crea el string lineaya que vamos a comprobar si las lineas estan null 
            //para el caso del IF
            //string linea = "";

            //para leer desde el primer caracter hasta el final del archivo
            texto = fichero.ReadToEnd();

            //whie para recorrer 1 a 1 todas las lineas
            /* while (linea != null)
             {
                 //para que me guarde en la variable linea la primera linea de string del archivo
                 linea = fichero.ReadLine();
                 //a la variable texto se le va añadiendo las cadenas de string obtenidas de las diferentes lineas
                 texto += linea;
             }*/

            //SIEMPRE HAY QUE CERRAR EL ARCHIVO PARA LIBERARLO
            fichero.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Fichero no encontrado" + e);

        }

        return texto;
    }
    #endregion


    //CREAR UN FICHERO
    #region CrearFichero
    private static void CrearFichero(string ruta, string contenido)
    {
        try
        {
            //SIEMPRE PONER LA RUTA DONDE SE QUIERE QUE SE CREE
            StreamWriter fichero = File.CreateText(ruta);
            fichero.Write(contenido);
            fichero.Close();
        }
        catch (Exception e)
        {

            Console.WriteLine("Fichero no encontrado" + e);
        }
    }
    #endregion

    //MODIFICAR UN FICHERO
    #region ModificarFichero
    private static void ModificarFichero(string ruta, string contenido)
    {
        //Leer y almacenar e contenido orginal
        //almaceno en una variable todo el contenido del fichero
        string contenidoOriginal = LeerFichero(ruta);
        //Concatenarlo (unirlo)
        //almaceno el contenido final en otra variable la cual tendra todo el inicial + el introducido
        string contenidoFinal = contenidoOriginal + contenido;
        //Escribir en el fichero
        CrearFichero(ruta, contenidoFinal);

    }
    #endregion


    //METODO PARA REALIZAR LAS PRUEBAS
    public static void RealizarTest()
    {
        #region leeFichero
        //guardo el texto que me devuelve el metodo en la variable de tipo string
        //la ruta empieza en bin/Debug por lo que si tenemos el archivo en la raiz seria ../../../ porque subes tres niveles
        string texto = LeerFichero("../../../TextFile1.txt");
        // y despues la muestro
        Console.WriteLine(texto);
        #endregion

        #region crearFichero
        //se crea un fichero nuevo en la ruta indicada y el texto que tiene el archvo
        CrearFichero("../../../Resources.txt", "El Contenido que tiene");

        #endregion

        #region modificarFichero
        //se e pasa la ruta y lo que queremos añadr al ficher 
        //ModificarFichero("../../../TextFile1.txt", "\nTexto nuevo introducido");
        #endregion

        Console.ReadLine();
    }
}

