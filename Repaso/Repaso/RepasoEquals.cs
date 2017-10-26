using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Quaternion
{
    //MIEMBROS
    #region Miembros
    //x,z,y,w
    private float x;
    private float y;
    private float z;
    private float w;

    #endregion

    //CONSTRUCTORES
    #region Constructores
    public Quaternion()
    {
        this.x = 0f;
        this.y = 0f;
        this.z = 0f;
        this.w = 0f;
    }

    public Quaternion(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }
    #endregion


    //GETTERSYSETTES
    #region GetterYSetters
    public float X
    {
        get { return x; }
        set { x = value; }
    }

    public float Y
    {
        get { return y; }
        set { y = value; }
    }

    public float Z
    {
        get { return z; }
        set { z = value; }
    }


    public float W
    {
        get { return w; }
        set { w = value; }
    }

    #endregion

    //FUNCIONES 
    #region Funciones
    //TO STRING
    public override string ToString()
    {

        return string.Format("( {0} , {1} , {2} , {3} )", X, Y, Z, W);
    }

    //COMPROBAR SI SON IGUALES
    public override bool Equals(object obj)
    {
        if (obj is Quaternion)
        {
            Quaternion aux = (Quaternion)obj;
            return this.X == aux.X &&
                this.Y == aux.Y &&
                this.Z == aux.Z &&
                this.W == aux.W;
        }
        else
        {
            return false;
        }
    }

    //IMPRIME SI SON IGUALES
    public static void ImprimeSiSonIguales(Quaternion q1, Quaternion q2)
    {
        bool iguales = q1.Equals(q2);

        if (iguales)
        {
            Console.WriteLine("Son iguales");
        }
        else
        {
            Console.WriteLine("No son iguales");
        }

    }

    //METODO QUE DEVULVA LA MAYOR W
    public static Quaternion BuscarMayorW(List<Quaternion> lis1)
    {
        Quaternion mejorCandidato = null;
        foreach (Quaternion posibleCandidato in lis1)
        {
            if (mejorCandidato == null || posibleCandidato.W > mejorCandidato.W)
            {
                mejorCandidato = posibleCandidato;
            }
        }
        return mejorCandidato;
    }

    //METODO PARA SABER SI ALGUNO DE LOS PARAMETROS ES NEGATIVO
    public static bool ExisteQuaternionConValorNegativo(List<Quaternion> lis1)
    {
        bool referencia = false;
        foreach (Quaternion q in lis1)
        {
            if (q.X < 0 || q.Y < 0 || q.Z < 0 || q.W < 0)
            {
                referencia = true;
            }
        }
        return referencia;
    }

    //METODO PARA SUMAR TODAS LAS Z DE UN QUATERNION
    public static float SumaZQuaternion(List<Quaternion> quaterniones)
    {
        float suma = 0f;
        foreach (Quaternion q in quaterniones)
        {
            suma += q.Z;
        }
        return suma;
    }

    //METODO PARA SUMAR CUANTOS CUATERNIONES TIENEN LA X  EN 0
    public static int QuaternionesConXNulo(List<Quaternion> quaterniones)
    {
        int res = 0;
        foreach (Quaternion q in quaterniones)
        {
            if (q.X == 0)
            {
                res++;
            }

        }
        return res;
    }


    //BUSQUEDA DE CUATERNIONES CUYA X ESTA ENTRE A Y B (pasados por parametros)
    public static List<Quaternion> QuaternionesXEnRango(List<Quaternion> quaterniones, float a, float b)
    {
        List<Quaternion> res = new List<Quaternion>();
        foreach (Quaternion q in quaterniones)
        {
            if (q.X >= a && q.X <= b)
            {
                res.Add(q);
            }
        }
        return res;
    }

    #endregion

}

public class RepasoEquals
{

    public static void RealizarTest()
    {
        Quaternion q1 = new Quaternion(0.1f, 0.2f, 0.3f, 0.4f);
        Quaternion q2 = new Quaternion(0.5f, 0.4f, 0.5f, 0.9f);
        Quaternion q3 = new Quaternion(0.2f, 0.1f, 0.8f, 0.4f);
        Quaternion q4 = new Quaternion(0.5f, 0.4f, 0.5f, 0.9f);
        Quaternion q5 = new Quaternion(0.4f, 0.5f, 0.8f, 0.7f);

        q1.Equals(q2);
        q1.Equals(q4);

        Console.WriteLine(q1);

        Console.ReadLine();
    }




}

