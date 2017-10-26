// EJERCICIOS PAG 44
//44 - 1
public class Punto2D
{

    //MIEMBROS
    public float x;
    public float y;

    //CONSTRUCTORES
    public Punto2D(float x,float y)
    {
        this.x = x;
        this.y = y;
    }


    public Punto2D()
    {
        this.x = 0.292f;
        this.y = 1.2323f;
    }
    //GETTERS Y SETTERS

    public float GetX()
    {
        return x;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public float GetY(float y)
    {
        return y;
    }
    public void SetY(float y)
    {
        this.y = y;
    }


}