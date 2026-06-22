namespace GeoLib
{
    public class Square : Shape
    {
        public float Side { get; private set; }
        public Square(float side) : base("Cuadrado")
        {
            if (side <= 0)
            {
                throw new Exception("Value of parameter side is not valid. Value must be greater than 0");
            }

            this.Side =  side;
        }

        public override float GetArea()
        {
            return this.Side * this.Side;
        }

        public override float GetPerimeter()
        {
            return this.Side * 4;
        }

        public override string Render()
        {
            string render = "";

            for (int x = 0; x < this._quad; x++)
            {
                for (int y = 0; y < this._quad; y++)
                {
                    if (x == 0 || x == this._quad - 1 || y == 0 || y == this._quad - 1)
                    {
                        render += ". ";
                    }
                    else
                    {
                        render += "  ";
                    }
                }
                render += "\n";
            }

            return render;
        }
    }
}
