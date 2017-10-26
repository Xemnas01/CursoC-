public class Perro : Animal
{

    public Perro()
    {
        base.Raza = "Perro";
    }

    //para modificar una funcion de una clase  padre se usa la palabra OVERRIDE
    //forma 1
    /*
    public override void ReproducirSonido()
    {
        System.Console.WriteLine("GUAU");

    }
    */
    public override string ReproducirSonido()
    {
        string s = base.ReproducirSonido();
        return s + "GUAU!";
    }
}