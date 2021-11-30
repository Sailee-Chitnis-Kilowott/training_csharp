using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_csharp
{
    internal class challenge3
    {
        public static void test3()
        {
            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "Посмотреть русский вывод";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }
    }
}
