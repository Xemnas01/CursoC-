
class Evento
{
    //MIEMBROS
    public string nombre;
    public int tiempo; //años
    public string lugar;

    // CONSTRUCTORES
    //POR DEFECTO

    public Evento()
    {
        this.nombre = "Desconocido";
        this.tiempo = 0;
        this.lugar = "Desconocido";
    }

    public Evento(string nombre,int tiempo,string lugar)
    {
        this.nombre = nombre;
        this.tiempo = tiempo;
        this.lugar = lugar;
    }

    //CONSTRUCTOR PARA HACERLO CON SPLIT (pasando datos por string)
    public Evento(string datos)
    {
        datos = datos.Replace(" ", ""); //eliminar espacios posibes
        string[] EventoSplit = datos.Split(','); //trocear los datos en las ,

        this.nombre = EventoSplit[0];
        this.tiempo =int.Parse(EventoSplit[1]);
        this.lugar = EventoSplit[2];

    }


    //GETTERS Y SETTERS
    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }


    public string GetLugar()
    {
        return lugar;
    }

    public void SetLugar(string lugar)
    {
        this.lugar = lugar;
    }

    public int GetTiempo()
    {
        return tiempo;
    }

    public void SetTiempo(int tiempo)
    {
        this.tiempo = tiempo;
    }

    public override string ToString()
    {
        string s = base.ToString();
        s = "----Eventos----\n";
        s = s + "Nombre: " + GetNombre() +
            "\nTiempo: " + GetTiempo() +
            "\nLugar: " + GetLugar();
        return s; 
    }

    //TODO ToString



}

