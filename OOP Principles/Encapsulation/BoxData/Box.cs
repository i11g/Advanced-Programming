using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length; 
    private double _width; 
    private double _heigth;

    public Box(double length, double width, double heigth)
    { 
        Length= length;
        Width= width;   
        Heigth= heigth;
    }

    public double Length
    {
        get { return _length; }
        set
        { if(value <= 0)
            {
                throw new ArgumentException($"{this.Length} cannot be zero or negative.");
            }

            _length = value;
        }
    } 

    public double Width
    {
        get { return _width; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException($"{this.Width} cannot be zero or negative.");
            }
            _width=value;
        }
        
    }

    public double Heigth
    {
        get { return _heigth; }
        set
        {
            if(value<0)
            {
                throw new ArgumentException($"{this.Heigth} cannot be zero or negative.");
            }
            _heigth = value;
        }
    }

    public double SurfaceArea()
    {
        return 2 * this.Length * this.Width + 2 * this.Length * this.Heigth + 2 *this.Width * this.Heigth;
    }

    public double Volume ()
    {
        return this.Heigth * this.Length * this.Width;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():f2}\n" +
            $"Volume – {this.Volume():f2}";  
    }
}
