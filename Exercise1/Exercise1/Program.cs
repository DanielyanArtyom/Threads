using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Alarm time");
            Console.WriteLine($"{DateTime.Now.Hour}");
            

            int hours = Convert.ToInt32(Console.ReadLine());

            int minutes = Convert.ToInt32(Console.ReadLine());

            var TimeAlarm = new Alarm(hours, minutes);

            TimeAlarm.CallingAlarm();
            
        }
    }
}
