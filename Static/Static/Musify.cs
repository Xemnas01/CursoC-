using System.Collections.Generic;
using System;
using System.IO;

public static class Musify
{

    private const string ruta = "../../Resources/Ejercicio.txt";
    //MIEMBROS
    #region miembros
    private static List<Song> songs;

    private static List<Playlist> playlists;
    #endregion

    //GETTERS Y SETTERS
    #region gettersysetters
    public static List<Song> Songs
    {
        get { return songs; }
        set { songs = value; }
    }

    public static List<Playlist> Playlists
    {
        get { return playlists; }
        set { playlists = value; }
    }

    #endregion

    //FUNCIONES EXPORT
    #region FuncionesExport
    //FUNCION EXPORT
    public static void Export()
    {
        string contenidoCanciones = ConvertSongsToString();
        string contenidoPlaylist = ConvertPlayListToString();
        string datosCompletos = "";
        try
        {
            //SIEMPRE PONER LA RUTA DONDE SE QUIERE QUE SE CREE
            StreamWriter fichero = File.CreateText(ruta);
            datosCompletos += contenidoCanciones;
            fichero.WriteLine(datosCompletos);
            fichero.WriteLine("*+++*\n");

            datosCompletos = contenidoPlaylist;
            fichero.WriteLine(datosCompletos);
            fichero.Close();
            Console.WriteLine("Exportacion completada");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al exportar los datos" + e);
        }
    }

    //creamos funcion pra convertir las canciones en string con el 1º formato indicado
    private static string ConvertSongsToString()
    {
        string contenido = "";

        foreach (Song s in songs)
        {
            string contCancion = "";
            contCancion = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", s.Name, s.Author, s.Duration, s.Year,(int)( s.Genre), s.Score);
            contCancion += "\n";

            contenido += contCancion;
        }
        return contenido;
    }

    //creamos funcion para converitr las lista a string y se pongnan con el 2º formato indicado
    private static string ConvertPlayListToString()
    {
        string contenido = "";

        foreach (Playlist play in playlists)
        {
            string conteniPlaylis = "";
            string playListName = play.Name;
            string songList = "";
            foreach (Song s in play.Songs)
            {
                string songData = string.Format("{0}:{1}", s.Name, s.Author);
                songList += songData + ",";
            }

            conteniPlaylis += string.Format("{0}-{1}", play.Name, songList);
            contenido += conteniPlaylis;
        }
        return contenido;
    }
    #endregion

    //FUNCIONES IMPORT
    #region FuncionesImport
    //IMPORT
    public static void Import()
    {
        //leo el fichero y lo troceo en lineas
        List<string> lineas = ReadFile(ruta);
        //listas para almacenar canciones y playlist
        List<string> songsLineas = new List<string>();
        List<string> playlistsLineas = new List<string>();
        //para comprobar si son playlist
        bool isPlayList = false;
        //para que me recorra todas las lines de la lista lineas
        foreach (string linea in lineas)
        {
            //si a linea es *+++* todas las siguientes son Playlist
            if (linea == "*+++*")
            {
                isPlayList = true;
            }
            else
            {
                //si no es una playlist (si entra en el else es que no ha entrado en playlist
                //ya que en el fichero| canciones *+++* listas  |
                if (!isPlayList)
                {
                    songsLineas.Add(linea);
                }
                else
                {
                    playlistsLineas.Add(linea);
                }
            }
        }

        Songs = new List<Song>();
        Playlists = new List<Playlist>();
        foreach (string linea in songsLineas)
        {
            Song s = new Song();
            Songs.Add(s);
        }

        foreach (string linea in playlistsLineas)
        {
            Playlist play = new Playlist();
            Playlists.Add(play);
        }
        Console.WriteLine("Importacion Completada");
    }

    //para leer el fichero linea por linea y lo almaceno en una lista de string k vaya almacenando cada linea
    public static List<string> ReadFile(string ruta)
    {
        List<string> lineas = new List<string>();
        try
        {

            StreamReader archivo = File.OpenText(ruta);
            string linea = "";
            while (linea != null)
            {
                linea = archivo.ReadLine();
                //LA ULTIMA LINEA DE UN ARCHIVO SIEMPRE A LEE COMO NULA, LO CUAL CONTROLAMOS ASI
                if (linea != null)
                {
                    lineas.Add(linea);
                }
            }
            archivo.Close();

        }
        catch (Exception e)
        {

            Console.WriteLine("No se puede acceder al fichero");
        }
        return lineas;
    }


    public static Song GetSongByNameAndAuthor(string name, string author)
    {
        Song s = null;
        foreach (Song  song in Songs)
        {
            if (song.Name == name && song.Author == author)
            {
                s = song;
            }
        }
        return s;
    }

    #endregion

    //FUNCIONALIDADES PARTE 3
    #region funcionaldades
    //MAS ANTIGUA
    public static Song MasAntigua(string nombrePlaylist)
    {
        Song res = null;
        foreach (Playlist play in Playlists)
        {
            if (play.Name == nombrePlaylist)
            {
                foreach(Song s in Songs)
                {
                    if(s.Year < res.Year)
                    {
                        res = s;
                    }
                }                
            }
        }
        Console.WriteLine("La cancion mas antigua es: " + res);
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
        //HAY QUE INICIALIZAR LA VARIABLE ESTATICA QUE CREAMOS AL PRINCIPIO (miembro)
        songs = new List<Song>();
       // Song s = new Song("cancion1", "autor1", 34, 1998, Genre.Latin, 3);
        Song s2 = new Song("cancion1", "autor1", 67, 2008, Genre.Electronic, 2);
        Song s3 = new Song("cancion3", "autor3", 45, 2004, Genre.Folk, 5);
        Song s4 = new Song("cancion1", "autor1", 34, 2000, Genre.Latin, 3);
        Song s5 = new Song("asdihas", "asdiasjd", 56, 1801, Genre.Country, 4);
       // songs.Add(s);
        songs.Add(s2);
        songs.Add(s3);
        songs.Add(s4);
        songs.Add(s5);
       // Musify.Songs = songs;
        playlists = new List<Playlist>();
        Playlist play1 = new Playlist("NOMBRELISTA", songs.Count - 1, songs);
       
        MasAntigua("play1");
    }
    #endregion



}