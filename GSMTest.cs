using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class GSMTest
    {
        static void Main()
        {
            GSM firstGSM = new GSM("Samsung", "Germany", 1000);
            GSM secondGSM = new GSM("Nokia", "Italy", 200.99m, "Boris");
            GSM thirdGSM = new GSM("Sony", "Bulgaria", 300);

            GSM[] phones = new GSM[] { firstGSM, secondGSM, thirdGSM };

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }


    }

