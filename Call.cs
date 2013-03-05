using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Call
    {
    //Fields
        public string date;
        public string time;
        public string dialedPnoneNumber;
        public decimal duration;

    // Constructors
        public Call()
        {
        }
        public Call(string dialedPnoneNumber, int duration)
        {
            this.dialedPnoneNumber = dialedPnoneNumber;
            this.duration = duration;
        }
        public Call(string date, string dialedPnoneNumber, int duration)
        {
            this.date = date;
            this.dialedPnoneNumber = dialedPnoneNumber;
            this.duration = duration;
        }
      public Call(string date, string time, string dialedPnoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPnoneNumber = dialedPnoneNumber;
            this.duration = duration;
        }
        // Properties
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialedPnoneNumber
        {
            get { return this.dialedPnoneNumber; }
            set { this.dialedPnoneNumber = value; }
        }

        public decimal Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }

