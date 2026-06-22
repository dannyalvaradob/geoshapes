namespace GeoLib
{
    public class Rectangle : Shape
    {
        public float Base {  get; private set; }
        public float Height { get; private set; }
        public Rectangle(float bas, float height) : base("Rectangulo")
        {
            if (bas <= 0)
            {
                throw new Exception("Value of parameter bas is not valid. Value must be greater than 0");
            }

            if (height <= 0)
            {
                throw new Exception("Value of parameter height is not valid. Value must be greater than 0");
            }

            if (bas == height)
            {
                throw new Exception("\"Value of parameters bas and height is not valid. Value must not be equal\"");
            }

            this.Base = bas;
            this.Height = height;
        }

        public override float GetArea()
        {
            return this.Base * this.Height;
        }

        public override float GetPerimeter()
        {
            return 2 * (this.Base  + this.Height);
        }

        public override string Render()
        {
            string render = "";
            int quadBase;
            int quadHeight;

            if (this.Base > this.Height)
            {
                quadBase = this._quad + ((this._quad + 2) / 2);
                quadHeight = this._quad;
            }
            else
            {
                quadBase = this._quad;
                quadHeight = this._quad + ((this._quad + 2) / 2);
            }

            for (int x = 0; x < quadHeight; x++)
            {
                for (int y = 0; y < quadBase; y++)
                {
                    if (x == 0 || x == quadHeight - 1 || y == 0 || y == quadBase - 1)
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
