using System;
using System.Text;

namespace BoxData;

public class Box
{
     
    private double _length; 
    private double _width; 
    private double _height;

    public double Length
    {
        get
        {
            return _length;
        }

        set 
        {  
            if(value <= 0)
            {
                throw new ArgumentException($"{this.Length} cannot be zero or negative.");
            }
            this._length = value;
        }
    }
    public double Width
    {
        get
        {
            return _width;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.Width} cannot be zero or negative.");
            }
            this._width = value;
        }
    }
    public double Height
    {
        get
        {
            return _height;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.Height} cannot be zero or negative.");
            }
            this._height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea ()
    {
        
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }
    
    public double Volume()
    {
        return Length * Width * Height;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():f2}\n"+
            $"Volume – {this.Volume():f2}";
    }
}
