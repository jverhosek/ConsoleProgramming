Console.WriteLine("Enter Length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height:");
int height = Convert.ToInt32(Console.ReadLine());


var cube = new Cube(width, height, length);
var triangle = new Triangle() { Height = height, Length = length, Hypotenuse = 10 };
var triangle1 = new Triangle();
var triangle2 = new Triangle(height, length, 10);
var triangle3 = new Triangle(10);
var rectangle = new Rectangle { Width = width, Height = height };

//cube.Length = length;
//cube.Width = width;
//cube.Height = height;

//triangle.Length = length;
//triangle.Height = height;

//rectangle.Length = length;
//rectangle.Width = width;   

Console.WriteLine("Cube Area Is: " + cube.getArea());
Console.WriteLine("Cube Volume Is: " + cube.getVolume());

Console.WriteLine("Triangle Area Is: " + triangle.getArea());

Console.WriteLine("Rectangle Area Is: " + rectangle.getArea());
