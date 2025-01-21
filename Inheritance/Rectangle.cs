﻿using System.ComponentModel.DataAnnotations;

class Rectangle : Shape, IShape
{
    public double Width { get; set; }

    public double getArea()
    {
        return Width * Length * Height;
    }

}

