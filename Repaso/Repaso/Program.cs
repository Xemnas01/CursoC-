using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        #region ejemplo
        /*
        //UNICA FORMA DE EJECUTAR UN METODO ESTATICO
        //SOLO SE PUEDE EJECUTAR ESE METODO CREANDO UNA INSTANCIA DE LA CLASE K CONTIENE ESE METODO
        RepasoListas ejecutarMetodoStatic = new RepasoListas();
        ejecutarMetodoStatic.EjecutarMetodoNoEstatico();
        Console.ReadLine();

        //SE PUEDE LLAMAR A UN METODO ESTATICO SIN CREAR LA ESTANCIA
        RepasoListas.EjecutarMetodoEstatico();
        */
        #endregion

        //  RepasoListas.RealizarTest();
         RepasoFicheros.RealizarTest();
       // RepasoEquals.RealizarTest();
        
    }
}
