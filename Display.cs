using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Display
{
    //Fields
    private int size;
    private int numberOfColors;

    //Constructors
    public Display()
    {
    }

    public Display(int size, int numberOfColors)
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }

    public Display(int size)
    {
        this.Size = size;
    }

    public int Size
    {
        get { return this.size; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Size must be more than 0mm");
            }
            else
            {
                this.size = value;
            }
        }
    }

    public int NumberOfColors
    {
        get { return this.numberOfColors; }
        set
        {
            if (value <= 64)
            {
                throw new ArgumentException("NumberOfColors must be more than 64k");
            }
            else
            {
                this.numberOfColors = value;
            }
        }
    }
    //Methods
    //Override ToString
    public override string ToString()
    {
        return string.Format("Size: {0} \n\numberOfColors: {1} \n\r", size, numberOfColors);
    }
}
