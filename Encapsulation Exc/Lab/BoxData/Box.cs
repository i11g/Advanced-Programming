using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        set { 
            if(value <=0)
            {
                throw new ArgumentException($"Length cannot be zero or negative"); 
            }
            length = value; }
    }
    public double Width
    {
        get { return width; }
        set {
            if (value <= 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative");
            }
            width = value; }
    }
    public double Height
    {
        get { return height; }
        set {
            if (value <= 0)
            {
                throw new ArgumentException($"Heght cannot be zero or negative");
            }
            height = value; }
    }

    public Box (double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;        
    }

    public double SurfaceArea(double width, double height, double length)
    {  
        return (2*Length*Height+2*Length*Width+2*Width*Height);
    }
    public double Volume(double width, double heigth, double length)
    {
        return (Length * Width * Height);
    }

    public override string ToString()
    {
        return $"Surface area - ;
    }
}
