using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDayAndTime());
        }

        static string GetDayAndTime()
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            string time = DateTime.Now.ToLongTimeString();

            return String.Format("Today is {0}\nCurrent time is {1}", day, time);
        }
    }
}
