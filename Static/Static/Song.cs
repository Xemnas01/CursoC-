
//Enumerado de genero
#region enumGenero
public enum Genre
{
    Country = 0,
    Electronic = 1,
    Folk = 2,
    HipHop = 3,
    Jazz = 4,
    Pop = 5,
    Rock = 6,
    Latin = 7,
    Metal = 8,
    Classic = 9
}
#endregion
public class Song
{
    //MIEMBROS
    #region miembros

    string name;
    string author;
    int duration; //[0,inf)
    int year; //[1800-2017]
    Genre genre;
    int score; //[0-5]

    #endregion

    //CONSTRUCTORES
    #region Constructores
    //Constructor por defecto
    public Song()
    {
        this.name = "Desconocido";
        this.author = "Desconocido";
        this.duration = 0;
        this.year = 1800;
        this.score = 0;

    }
    //constructor relleno
    public Song(string name, string author, int duration, int year, Genre genre, int score)
    {
        this.name = name;
        this.author = author;
        if (duration >= 0)
        {
            this.duration = duration;
        }
        else
        {
            this.duration = 0;
        }
        if (year >= 1800 && year <= 2017)
        {
            this.year = year;
        }
        else
        {
            this.year = 1800;
        }

        this.genre = genre;
        this.score = score;
    }
    #endregion


    //GETTERSYSETTERS
    #region gettersSetters

    public string Name
    {
        get { return this.name; }
    }

    public string Author
    {
        get { return this.author; }
    }

    public int Duration
    {
        get
        {
            //para comprobar que la cduracion de la cancion es de mas de 0 segundos
            //si es menor que 0 que la ponga a 0
            if (duration < 0)
            {
                return 0;
            }
            else
            {
                return this.duration;
            }

        }
    }

    public int Year
    {
        get
        {
            //para comprobar que el año este entre 1800 y 2017
            if (this.year >= 1800 && this.year <= 2017)
            {
                return this.year;
            }
            else
            {
                //si el numero en inferior a 1800 o mayor a 2017 el año por defecto sera 1800
                System.Console.WriteLine("El año introducido no es correcto.");
                return 1800;
            }
        }
    }

    public Genre Genre
    {
        get { return this.genre; }
    }

    public int Score
    {
        get
        {
            if (this.score >= 0 && this.score <= 5)
            {
                return this.score;
            }
            else
            {
                //si la puntuacion no estra entre 0 y 5 se contara como nvalida y se pondra a 0
                System.Console.WriteLine("Puntuación no valida");
                return 0;
            }
        }
        set
        {
            if (this.score >= 0 && this.score <= 5)
            {
                this.score = value;
            }
            else
            {
                //si la puntuacion introducida no es correcta
                System.Console.WriteLine("La puntuacion introducida no es valida.");
                this.score = 0;
            }
        }
    }
    #endregion

    //IGUALDAD 
    #region criterioIgualdad

    public override bool Equals(object obj1)
    {
        bool respuesta = false;
        //Si el objeto indicado es unacancion
        if (obj1 is Song)
        {

            //me creo un auxiliar y guardo el objeto casteado a tipo cancion
            Song aux = (Song)obj1;
            if (this.Name == aux.Name && this.Author == aux.Author)
            {
                System.Console.WriteLine("Son la misma cancion");
                respuesta = true;
            }
            else
            {
                System.Console.WriteLine("No son la misma cancion");
                respuesta = false;
            }


        }
        else
        {
            System.Console.WriteLine("El objeto introducido no es una cancion");
            respuesta = false;
        }

        return respuesta;
    }

    #endregion

    //TOSTRING
    #region ToString
    //sobrecarga del ToString
    public override string ToString()
    {
        return string.Format("{0} - ( {1} - {2} ). {3}", Name, Author, Year, Score);
    }
    #endregion

    //PRUEBA
    #region prueba
    /*
  public static void TestPrueba()
  {
      Song s = new Song("cancion1", "autor1", 34, 1998, Genre.Latin,3);
      Song s2 = new Song("cancion1", "autor1", 67, 2008, Genre.Electronic, 2);
      Song s3 = new Song("cancion3", "autor3", 45, 2004, Genre.Folk, 3);
      Song s4 = new Song("cancion1", "autor1", 34, 2000, Genre.Latin, 3);

      System.Console.WriteLine(s);

      System.Console.WriteLine("COMPARACION");

      System.Console.WriteLine(s+"\n"+s3+"\n");
      s.Equals(s3);
      System.Console.WriteLine(s + "\n" + s2 + "\n");
      s.Equals(s2);
      System.Console.WriteLine(s + "\n" + s4 + "\n");
      s.Equals(s4);
      System.Console.WriteLine(s + "\n" + s + "\n");
      s.Equals(s);


  }
  */
    #endregion

}

