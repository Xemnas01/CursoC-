//Enumerado sexo

public enum Sexo
{
    NoEspicificado = 0,
    Hombre = 1,
    Mujer = 2
}

//clase persona

public class Persona
{

    public string nombre;
    public string apellidos;
    public int edad; //[0-120]
    public Sexo sexo;
    public string dni; //no modifcable


    //Constructores
    //POR DEFECTO
    public Persona() {
        this.nombre = "Desconocido";
        this.apellidos = "Desconocido";
        this.edad = 0;
        this.sexo = Sexo.Hombre;
        this.dni = "00000000-";
    }
    //RELLENADO
    public Persona(string nombre,string apellidos,int edad,Sexo sexo,string dni)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.edad = edad;
        this.sexo = sexo;
        this.dni = dni;
    }
    //PERSONA SPLIT
    //se crea otro constructor de tipo persona que cuando recibe el string 
    //con los datos de a persona nueva (separados por ,) y los separa automaticamente
    public Persona(string datos)
    {
        datos = datos.Replace(" ",""); //eliminar espacios posibes
        string[] PersonaSplit = datos.Split(','); //trocear los datos en las ,

        this.nombre = PersonaSplit[0];
        this.apellidos = PersonaSplit[1];
        this.edad = int.Parse(PersonaSplit[2]);
        //Se hace asi para pasar el sexo a int y que coja el enumerado por defecto
        this.sexo = (Sexo)(int.Parse(PersonaSplit[3]));
        this.dni = PersonaSplit[4];
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

    public string GetApellidos()
    {
        return apellidos;
    }

    public void SetApellidos(string apellidos)
    {
        this.apellidos = apellidos;

    }
    public int GetEdad()
    {
        //la edad debe estar comprendida entre 0 y 120
        if (edad >= 0 && edad <= 120)
        {
            return edad;
        }
        else
        {
            edad = 0;
            return edad;
        }
        
    }

    public void SetEdad(int edad)
    {
        //la edad debe estar comprendida entre 0 y 120
        if(edad >= 0 &&  edad <= 120)
        {
            this.edad = edad;
        }
        else
        {
            System.Console.WriteLine("La edad debe estar entre 0 y 120");
            this.edad = 0;
        }
    }

    public Sexo GetSexo()
    {
        return sexo;
    }

    public void SetSexo(Sexo sexo)
    {
        this.sexo = sexo;
    }

    //solo get ya que dni no es modificable
    public string GetDNI()
    {
        return dni;
    }

    //SOBRECARGA TOSTRING

    public override string ToString()
    {
        string s = base.ToString();
        s = "Nombre: "+GetNombre()+
            "\nApellidos: "+GetApellidos()+
            "\nEdad: "+GetEdad()+
            "\nSexo: "+GetSexo()+
            "\nDNI: "+GetDNI();

        return s;
    }

}
