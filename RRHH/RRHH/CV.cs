
class CV
{
    //MIEMBROS
    public Evento[] estudios;
    public Evento[] experiencia;
    public Candidato candidato;


    //CONTRUCTORES
    public CV(Evento[] estudios, Evento[] experiencia, Candidato can)
    {
        this.estudios = estudios;
        this.experiencia = experiencia;
        this.candidato = can;
    }

    public CV()
    {
        this.estudios = new Evento[0];
        this.experiencia = new Evento[0];
        this.candidato = new Candidato();

    }
    //CONSTRUCTOR CV SPLIT
    public CV(string datos)
    {

        string[] CandidatoSplit = datos.Split(',');
        this.estudios = new Evento[datos[0]];
        this.experiencia = new Evento[datos[1]];
        this.candidato = new Candidato();

    }



    //GETTERS Y SETTERS
    public Evento[] GetEstudios()
    {
        return estudios;
    }

    public void SetEstudios(Evento[] estudios)
    {
        this.estudios = estudios;
    }
    public Evento[] GetExperiencia()
    {
        return experiencia;
    }

    public void SetExperiencia(Evento[] experiencia)
    {
        this.experiencia = experiencia;
    }
    //SOLO GET YA QUE NO ES UN VALOR MODIFICABLE
    public Candidato GetCandidato()
    {
        return candidato;
    }

    public override string ToString()
    {
        string s = base.ToString();
        s = "\n------------------Curriculum-------------";
        s += "\n------------------Estudios--------------";
        foreach(Evento evento in estudios)
        {
            s = s + estudios + "\n";
            //tambien puedeponerse asi
            // s += estudios + "\n";
            return s;
        }
        s += "\n----------------Experiencia------------------";
        foreach (Evento evento in experiencia)
        {
            s = s + experiencia + "\n";
            return s;

        }

        return s;
    }

}

