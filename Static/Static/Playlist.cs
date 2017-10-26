using System.Collections.Generic;

public class Playlist
{
    //MIEMBROS
    #region miembros
    string name;
    int songCount;
    List<Song> songs;
    #endregion
    //CONSTRUCTORES
    #region constructores
    //por defecto
    public Playlist()
    {
        this.name = "Desconocido";
        this.songCount = 0;
        this.songs = null;
    }

    public Playlist(string name, int songCount, List<Song> songs)
    {
        this.name = name;
        this.songCount = songCount;
        this.songs = songs;
    }
    #endregion

    //MEDIA DURACION
    #region mediaDuracion
    public int TotalDuration()
    {
        int contMedia = 0;
        foreach (Song s in Songs)
        {
            contMedia += s.Duration;
        }
        return contMedia;
    }
    #endregion

    //MEDIAVALORACION
    #region mediaValora
    public float AverageScore()
    {
        float totalMedia = 0;
        foreach (Song s in songs)
        {
            totalMedia += s.Score;
        }
        totalMedia = totalMedia / songs.Count;
        return totalMedia;
    }


    #endregion

    //GETTERSYSETTERS
    #region gettersSetters

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int SongCount
    {
        get { return Songs.Count; }

    }

    public List<Song> GetList()
    {

        return this.songs;
    }

    public List<Song> Songs
    {
        get { return this.songs; }
        set { this.songs = value; }
    }


    #endregion

    //CRITERIOIGUALDAD
    #region criterioIgualdad
    public override bool Equals(object obj)
    {
        if (obj is Playlist)
        {
            Playlist aux = (Playlist)obj;
            //creas un booleano que guarde el resultado de la comparacion entre el nombre de las dos playlist
            bool res = this.Name == aux.Name;
            //para comprobar si ambas listas tienen el mismo numero de canciones
            if (res && this.SongCount == aux.SongCount)
            {
                foreach (Song s in songs)
                {
                    if (!aux.Songs.Contains(s))
                    {
                        res = false;
                        break;
                    }
                }
            }
            return res;
        }
        else
        {
            return false;
        }

        /*
         otra forma de hacerlo es; 
         using System.Linq;
         res = Songs.SequenceEqual(aux.Songs);
         */
    }
    #endregion

    //TOSTRING
    #region toString
    public override string ToString()
    {
        string s1 = string.Format("\n--- {0} ---\n", this.Name);
        foreach (Song s in songs)
        {
            s1 += string.Format(" - {0}\n", s);
        }
        return s1;
    }

    #endregion

    //PRUEBA
    #region prueba
    public static void TestPrueba()
    {
        List<Song> canciones = new List<Song>();

        Song s = new Song("cancion1", "autor1", 34, 1998, Genre.Latin, 3);
        Song s2 = new Song("cancion1", "autor1", 67, 2008, Genre.Electronic, 2);
        Song s3 = new Song("cancion3", "autor3", 45, 2004, Genre.Folk, 3);
        Song s4 = new Song("cancion1", "autor1", 34, 2000, Genre.Latin, 3);


        canciones.Add(s);
        canciones.Add(s2);
        canciones.Add(s3);
        canciones.Add(s4);

        Playlist play1 = new Playlist("NOMBRELISTA", canciones.Count - 1, canciones);

        System.Console.WriteLine(play1);

        System.Console.WriteLine("MEDIA DE PUNTUACION TOTAL ES: " + play1.AverageScore());


        System.Console.WriteLine("DURACION TOTAL DE LA LISTA EN SEGUNDOS: " + play1.TotalDuration());




    }

    #endregion



}



