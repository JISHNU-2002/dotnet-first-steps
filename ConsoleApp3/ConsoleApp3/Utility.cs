using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Utility
    {
        public static void Weekend(this DateTime inputDate)
        {
            if (inputDate.DayOfWeek == DayOfWeek.Saturday || inputDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Not-Weekend");
            }
        }
    }
}
