using System.Collections.Generic;
using System;
using System.IO;

public static class Musify
{
    //MIEMBROS
    #region miembros
    private static List<Song> songs;

    private static List<Playlist> playlist;
    #endregion

    //GETTERS Y SETTERS
    #region gettersysetters
    public static List<Song> Songs
    {
        get { return songs; }
        set { songs = value; }
    }

    public static List<Playlist> Playlist
    {
        get { return playlist; }
        set { playlist = value; }
    }

    #endregion

    //FUNCIONES EXPORT
    #region FuncionesExport
    //FUNCION EXPORT
    public static void Export()
    {
        string ruta = "../../Resources/Ejercicio.txt";
        string contenidoCanciones = ConvertSongsToString();
        string contenidoPlaylist = ConvertPlayListToString();
        string datosCompletos = "";
        try
        {
            //SIEMPRE PONER LA RUTA DONDE SE QUIERE QUE SE CREE
            StreamWriter fichero = File.CreateText(ruta);
            datosCompletos += contenidoCanciones;
            fichero.WriteLine("\n*+++*\n");
            datosCompletos += contenidoPlaylist;
            fichero.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Fichero no encontrado" + e);
        }
    }

    //creamos funcion pra convertir las canciones en string con el 1º formato indicado
    private static string ConvertSongsToString()
    {
        string contenido = "";
        foreach (Song s in songs)
        {
            string contCancion = "";
            contCancion = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", s.Name, s.Author, s.Duration, s.Year, s.Genre, s.Score);
            contCancion += "\n";

            contenido = contCancion;
        }
        return contenido;
    }

    //creamos funcion para converitr las lista a string y se pongnan con el 2º formato indicado
    private static string ConvertPlayListToString()
    {
        string contenido = "";

        foreach (Playlist play in playlist)
        {
            string conteniPlaylis = "";
            string playListName = play.Name;
            string songList = "";
            foreach (Song s in play.Songs)
            {
                string songData = string.Format("{0}:{1}",s.Name,s.Author);
                songList += songData + ",";
            }

            conteniPlaylis += string.Format("{0}:{1}", play.Name, songList);
            contenido += conteniPlaylis + "\n";
        }
        return contenido;
    }
    #endregion


    //FUNCIONES IMPORT
    #region FuncionesImport

    #endregion


    //FUNCIONALIDADES PARTE 3
    #region funcionaldades
    //MAS ANTIGUA
    public static Song MasAntigua(Playlist play)
    {
        Song res = null;
        foreach (Song s in play.Songs)
        {
            if (res == null || s.Year < res.Year)
            {
                res = s;
            }
        }
        return res;
    }

    //EXISTE DETERMINADA CANCION EN UNA DETERMINADA LISTA
    public static bool ExisteDentroDe(Playlist play, string nombreCancion)
    {
        bool res = false;
        nombreCancion += nombreCancion.ToLower();
        foreach (Song s in play.Songs)
        {
            if (s.Name.ToLower() == nombreCancion)
            {
                res = true;
                break;
            }
        }
        return res;
    }

    //CUANTAS CANCIONES DE UN DET GENERO HAY EN UNA DETERMINADA LISTA
    public static int CancionesMismoGenero(Playlist play, Genre nombreGenero)
    {
        int total = 0;
        foreach (Song s in play.Songs)
        {
            if (s.Genre == nombreGenero)
            {
                total++;
            }
        }
        return total;
    }

    //PARA SACAR LA CANCION MAS VALORADA DE UNA PLAYLIST
    public static Song MasValorada(Playlist play)
    {
        Song respuesta = null;
        foreach (Song s in play.Songs)
        {
            if (respuesta == null || s.Score > respuesta.Score)
            {
                respuesta = s;
            }
        }
        return respuesta;
    }

    //DURACION TOTAL DE UNA PLAYLIST
    public static int DuracionTotal(Playlist play)
    {
        int total = 0;

        foreach (Song s in play.Songs)
        {
            if (s.Duration != 0)
            {
                total += s.Duration;
            }
        }
        return total;
    }

    //CREAR LISTA NUEVA FAVORITAS CON CANCIONES MAS VALORADAS (4 o mas)
    public static Playlist CrearListaFav(List<Playlist> listaPla)
    {
        Playlist respuesta = null;
        foreach (Playlist play in listaPla)
        {
            foreach (Song s in play.Songs)
            {
                if (s.Score >= 4)
                {
                    respuesta.Songs.Add(s);
                }
            }
        }
        return respuesta;
    }

    #endregion


    //PRUEBA DE FUNCIONES
    #region prueba
    public static void RealizarTest()
    {
        List<Song> canciones = new List<Song>();
        Song s = new Song("cancion1", "autor1", 34, 1998, Genre.Latin, 3);
        Song s2 = new Song("cancion1", "autor1", 67, 2008, Genre.Electronic, 2);
        Song s3 = new Song("cancion3", "autor3", 45, 2004, Genre.Folk, 5);
        Song s4 = new Song("cancion1", "autor1", 34, 2000, Genre.Latin, 3);

        canciones.Add(s);
        canciones.Add(s2);
        canciones.Add(s3);
        canciones.Add(s4);

        List<Playlist> listas = new List<Playlist>();
        Playlist play1 = new Playlist("NOMBRELISTA", canciones.Count - 1, canciones);
        Playlist play2 = new Playlist("nombrelista2", canciones.Count - 1, canciones);
        Playlist play3 = new Playlist("nombreLISTA3", canciones.Count - 1, canciones);

        listas.Add(play1);
        listas.Add(play2);
        listas.Add(play3);



        Export();
      //  Console.WriteLine("Canciones");
      //  foreach (Song song in canciones)
      //  {
      //      Console.WriteLine(song);
      //  }
      //  Console.WriteLine("Listas");
      //  foreach (Playlist play in listas)
      //  {
      //      Console.WriteLine(play);
      //  }

        
    }
    #endregion



}