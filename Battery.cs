using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Battery
{
    //Fields
    private BatteryType model;
    private int hourIdle;
    private int hourTalk;


    //Constructors
    public enum BatteryType
    {
        Lilon, NiMH, NiCd
    }

    public Battery(BatteryType model, int hourIdle, int hourTalk)
    {
        this.Model = model;
        this.HourIdle = hourIdle;
        this.HourTalk = hourTalk;
    }

    public Battery(int hourIdle, int hourTalk)
    {
        this.HourIdle = hourIdle;
        this.HourTalk = hourTalk;
    }


    //Properties
    public BatteryType Model
    {
        get { return this.model; }
        set
        {
            if (value != BatteryType.Lilon && value != BatteryType.NiCd && value != BatteryType.NiMH)
            {
                throw new ArgumentException("Invalid BatteryType!");
            }
            else
            {
                this.model = value;
            }
        }
    }

    public int HourIdle
    {
        get { return this.hourIdle; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("HourIdle cannot be negative!");
            }
            else
            {
                this.hourIdle = value;
            }
        }
    }

    public int HourTalk
    {
        get { return this.hourTalk; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("HourTalk cannot be negative!");
            }
            else
            {
                this.hourTalk = value;
            }
        }
    }
    //Methods
    //Override ToString
    public override string ToString()
    {
        return string.Format("Model: {0} \n\rhourIdle: {1} \n\rhourTalk: {2} \n\r", model, hourIdle, hourTalk);
    }

}







