
    public class PixelConHe : Punto2D
    {
        public string color;
  
        public PixelConHe(float x, float y, string color) : base(x,y)
         {
            this.x = x;
            this.y = y;
            this.color = color;
         }

        public string GetColor()
        {
            return color;
        }
    }

