
 class Candidato : Persona
{
    public string puesto;
    public float valoracion; //valor entre [0.0 - 1.0]
    public CV curr;
    //crear CV
    //CONSTRUCTORES
    //relleno
    public Candidato(string nombre, string apellidos, int edad, Sexo sexo, string dni, string puesto, CV curr, float valoracion) : base(nombre, apellidos, edad, sexo, dni)
    {
        base.nombre = nombre;
        base.apellidos = apellidos;
        base.edad = edad;
        base.sexo = sexo;
        base.dni = dni;
        this.puesto = puesto;
        this.curr = curr;
        this.valoracion = valoracion;
    }

    //POR DEFECTO
    public Candidato() : base()
    {
        base.nombre = "Desconocido";
        base.apellidos = "Desconocido";
        base.edad = 0;
        base.sexo = Sexo.Hombre;
        base.dni = "00000000-";
        this.puesto = "Desconocido";
        this.curr = null;
        this.valoracion = 0f;
    }

    //CANDIDATO POR SPLIT
    public Candidato(string datos):base(datos)
    {
        string[] CandidatoSplit = datos.Split(',');

        base.nombre = CandidatoSplit[0];
        base.apellidos = CandidatoSplit[1];
        base.edad = int.Parse(CandidatoSplit[2]);
        //Se hace asi para pasar el sexo a int y que coja el enumerado por defecto sin CV
        base.sexo = (Sexo)(int.Parse(CandidatoSplit[3]));
        base.dni = CandidatoSplit[4];
        this.puesto = CandidatoSplit[5];
        this.curr = null;
        this.valoracion =float.Parse(CandidatoSplit[6]);
        
    }

    public string GetPuesto()
    {
        return puesto;
    }

    public void SetPuesto(string puesto)
    {
        this.puesto = puesto;
    }

    public float GetValoracion()
    {
        if(valoracion >= 0 && valoracion <= 100)
        {
            this.valoracion = valoracion / 100;
            return valoracion;
        }
        else
        {
            return valoracion;
        }
       
    }

    public void SetValoracion()
    {
        if (valoracion >= 0 && valoracion <= 100)
        {
            this.valoracion = valoracion / 100;
        }
        else
        {
            System.Console.WriteLine("La valoracion debe estar entre 0 y 100");
            this.valoracion = 0;
        }
    }

    public CV GetCV()
    {
        return curr;
    }
    public void SetCV(CV cv)
    {
        this.curr = cv;
    }

    //SOBRECARGA METODO TOSTRING DE PERSONA
    public override string ToString()
    {
        string s = base.ToString();
        s = "\n-------------------CANDIDATO--------------------";
        s = s + "\nPuesto: " + GetPuesto() +
            "\nValoracion: " + GetValoracion()+
            GetCV();
        return s;
    }
}

