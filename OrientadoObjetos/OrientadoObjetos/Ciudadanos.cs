
//PAra que la clase ciudadanos pueda acceder a los metodos de Persona (para que herede sus metodos y variables) se utilizan los : entre e nombre de nuestra nueva clase
//y la clase de la cual queremos extender los metodos
public class Ciudadanos : Persona
{
    string dni;

    public string GetDNI()
    {
        return dni;
    }
    //Para añadirle el dni (en este caso) al padre del que hereda
    //al final del metodo hay que poner : base (para acceder a metodos del padre) y dentro del parentesis le pasamos los parametros de la persona para añadirle el dni
    public Ciudadanos(string nombre, string apellidos, int edad, Sexo sexo, string dni) : base(nombre,apellidos,edad,sexo)          
    {
        this.dni = dni;
    }

    public override string ToString()
    {
        //Cuando queremos modificar el ToString() del padre y añadiendole ago (haciendole la sobrecarga)
        //para acceder a metodo ToString() padre
        string s = base.ToString();
        //lo modificamos
        s = s + "\nDNI: " + GetDNI();
        //y lo devolvemos
        return s;
    }


}
