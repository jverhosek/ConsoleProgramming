using System.ComponentModel.DataAnnotations;

class Triangle : Shape, IShape
{
    public Triangle()
    {
        
    }

    public Triangle(int height, int length, int hypotenuse)
    {
        
    }

    public Triangle(int hypotenuse)
    {
        
    }
    public double Hypotenuse {  get; set; }

    public double getArea()
    {
        return .5 * Height * Length;
    }

}



