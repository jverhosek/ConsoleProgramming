class Cube : Shape, IShape
{
    public Cube(int width, int height, int length)
    {
        Width = width; 
        Height = height; 
        Length = length;
    }

    public double Width { get; set; }

    public double getArea()
    {
        return Width * Height;
    }

    public double getVolume()
    {
        return Width * Height * Length;
    }
}


