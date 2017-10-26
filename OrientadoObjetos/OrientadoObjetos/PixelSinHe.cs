//EJERCICIOS PAG 44 - 2
    public class PixelSinHe
    {

    //MIEMBROS
    public float x;
    public float y;
    public string color;

    //CONSTRUCTORES
    public PixelSinHe()
    {
        this.x = 0f;
        this.y = 0f;
        this.color = "Verde";
    }

    public PixelSinHe(float x,float y, string color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
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

    public string GetColor(string color)
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
}

