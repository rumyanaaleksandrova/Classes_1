using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

    class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private static GSM iPhone4S = new GSM("Iphone4S", "China", 300, "Rumi");
        private List<Call> callHistory;
        //Constructors
        public GSM()
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
        }
        
        public GSM(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public static GSM IPhone4S
        {
            get{return iPhone4S;}
            set{iPhone4S = value;}
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                string pattern = @"[a-zA-Z0-9 -_]{2,50}";
                Match match = Regex.Match(value, pattern);
                if (!match.Success)
                {
                    throw new ArgumentException("The model is not correct. Model must be between 2 and 50 symbols!");
                }
                else if (value.Length == 0)
                {
                    throw new ArgumentException("The model cannot be empty!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

             public string Manufacturer
            {
            get { return this.manufacturer; }
            set
            {
                string pattern = @"[A-Z][a-zA-Z0-9-_]{2,50}";
                Match match = Regex.Match(value, pattern);
                if (!match.Success)
                {
                    throw new ArgumentException("The manufacturer is not correct. manufacturer must be between 2 and 50 symbols!");
                }
                else if (value.Length == 0)
                {
                    throw new ArgumentException("The manufacturer cannot be empty!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be more than 0.00");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                string pattern = @"[A-Z][a-zA-Z ]{3,50}";
                Match match = Regex.Match(value, pattern);
                if (!match.Success)
                {
                    throw new ArgumentException("The owner is not correct. owner must be between 3 and 50 symbols!");
                }
                else if (value.Length == 0)
                {
                    throw new ArgumentException("The owner cannot be empty!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public List<Call> CallHistory
        {
            get{return this.callHistory;}
            set{this.callHistory = value;}
        }


        
        //Methods
        //Override ToString
        public override string ToString()
        {
            return string.Format("Model: {0} \n\rManufacturer: {1} \n\rPrice: {2} \n\rOwner: {3} \n\r", model, manufacturer, price, owner);
        }

        //Add CallHistory - Exercise_10
        public void AddCall(Call newCall)
        {
            if (callHistory == null)
            {
                callHistory = new List<Call>();
                callHistory.Add(newCall);
            }
            else
            {
                callHistory.Add(newCall);
            }
        }

        //Delete Call from CallHistory- Exercise_10
        public void DeleteCall(Call call)
        {
            if (callHistory != null)
            {
                callHistory.Remove(call);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        //clear CallHistory- Exercise_10
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        //Calculate Price - Ex_11
        public decimal TotalPrice(decimal pricePerMin)
        {
            decimal duration = 0;
            foreach (var call in this.CallHistory)
            {
                duration += call.Duration / 60m;
            }
            decimal priceForCallHistory = pricePerMin * duration;
            return priceForCallHistory;
        }
        }




    

