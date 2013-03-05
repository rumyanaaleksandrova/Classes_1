using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM phone1 = new GSM("Samsung", "Germany", 1000);
            GSM phone2 = new GSM("Nokia", "Italy", 200.99m, "Boris");
            GSM phone3 = GSM.IPhone4S;

            GSM[] phones = new GSM[] { phone1, phone2, phone3 };

            Call newCall1 = new Call("05.03.2013",  "0882203628", 100);
            Call newCall2 = new Call("01.02.2013", "11:00", "0882203628", 60);
            Call newCall3 = new Call("0882203628", 10);
            Call newCall4 = new Call("08.03.2013", "21:00", "0882203628", 360);

            phone1.AddCall(newCall1);
            phone1.AddCall(newCall2);
            phone1.AddCall(newCall3);
            phone1.AddCall(newCall4);

            //Print CallHistory
            StringBuilder result = new StringBuilder();
            foreach (var call in phone1.CallHistory)
            {
                result.AppendFormat("Date: {0}\nTime: {1}\nDialedNumber: {2}\nDuration (in seconds): {3}\n\n",
                    call.date, call.time, call.dialedPnoneNumber, call.duration);
            }

            Console.WriteLine(result.ToString());

            //Calculate TotalPrice
            decimal price = phone1.TotalPrice(0.37m);
            Console.WriteLine("{0:F2}лв.", price);

            //Calculate TotalPrice without long call
            phone1.DeleteCall(newCall4);
            decimal priceWithoutLongCall = phone1.TotalPrice(0.37m);
            Console.WriteLine("{0:F2}лв.", priceWithoutLongCall);

            //Clear CallHistory
            phone1.ClearCallHistory();

            StringBuilder resultClear = new StringBuilder();
            foreach (var call in phone1.CallHistory)
            {
                resultClear.AppendFormat("Date: {0}\nTime: {1}\nDialedNumber: {2}\nDuration (in seconds): {3}\n\n",
                    call.date, call.time, call.dialedPnoneNumber, call.duration);
            }
            Console.WriteLine();
            Console.WriteLine("The result after clear is: \n", resultClear.ToString());

        }

        }
    

