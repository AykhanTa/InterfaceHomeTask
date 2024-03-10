namespace InterfaceHomeTask
{
    internal class Rectangle:Figure
    {
        int _width;
        public int Width {
            get => _width;
            set 
            {
                if (value<0) 
                {
                    Console.WriteLine("Teref menfi ola bilmez.");
                    return;
                }
                _width = value;
            }
        }

        int _length;
        public int Length {
            get => _length;
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Teref menfi ola bilmez.");
                    return;
                }
                _length = value;

            } 
        }
        public Rectangle(int width,int length)
        {
            Width = width;
            Length = length;
            
        }

        public override void CalcArea()
        {
            Console.WriteLine(Width*Length);
        }
    }
}
