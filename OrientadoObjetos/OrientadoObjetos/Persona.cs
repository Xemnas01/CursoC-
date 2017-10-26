using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region enumerados
//La creación de enumerados siempre se situan fuera de la clase
public enum Sexo
{
    NoDefinido = 0,
    Hombre = 1,
    Mujer = 2
}
#endregion 


//CLASES 
//Se compone de: MIEMBROS, GETTERS Y SETTERS Y CONSTRUCTORES
public class Persona
{
    #region MIEMBROS
    //MIEMBROS(propiedades del objeto sin inicializar)
    //se pone el pubic delante para que sea visible en todo el proyecto
    //si se pusiera en private no seria visble en el proyecto
    public string nombre;
    public string apellidos;
    public int edad;
    public Sexo sexo;
    #endregion

    #region constructor
    //Acciones
    //Constructores
    public Persona(string a, string b, int e, Sexo s) {
        
        this.nombre = a;
        this.apellidos = b;
        this.edad = e;
        this.sexo = s;
        
    }

    //Para que si alguien le mete la edad como string que se pase a int
    public Persona(string a, string b, string e, Sexo s)
    {


        this.nombre = a;
        this.apellidos = b;
        this.edad = int.Parse(e);
        this.sexo = s;

    }
    

        //SE CREA OTRA CLASE PERSONA SIN PARAMETROS PARA QUE ACTUEN COMO PARAMETROS POR DEFECTO
        public Persona()
    {
        this.nombre = "Ningun nombre";
        this.apellidos = "Ningun Apellido";
        this.edad = 0;
        this.sexo = 0;
    }

    #endregion

    #region GETTERS y SETTERS
    //GETTES Y SETTERS
    //Los get siempre devuelven algo retur valorDevuelto;  || Para obtener un valor
    //Los sets this.valor = valor; || Para modificar o filtar un valor

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
        return edad;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public Sexo GetSexo()
    {
        return sexo;
    }
    public void SetSexo(Sexo sexo)
    {
        this.sexo = sexo;
    }

    //DERIVADAS
    public string GetNombreCompleto()
    {
        return GetNombre() + " " + GetApellidos();
    }

    #endregion


   



    //MODIFICACION DEL METODO ToString() para al imprimir desde el programa el objeto entero
    public override string ToString()
    {
        string s = "Nombre: " + GetNombre() + "\nApellidos: " + GetApellidos() + "\nEdad: " + GetEdad() + "\nSexo: " + GetSexo();
        return s;
    }




}