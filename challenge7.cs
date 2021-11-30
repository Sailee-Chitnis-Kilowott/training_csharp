using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_csharp
{
    internal class challenge7
    {
        public static void test7()
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
        }
       
    }
}
