using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Exercise1
{
    class Alarm
    {
        private int hour { get; set; }
        private int minute { get; set; }

        public Alarm(int hours, int minutes)
        {
            this.hour = hours;
            this.minute = minutes;
        }

        System.Timers.Timer AlarmTime;

        public void CallingAlarm()
        {

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                if ((hour == DateTime.Now.Hour) && (minute == DateTime.Now.Minute))
                {
                    AlarmTime = new System.Timers.Timer();

                    AlarmTime.Elapsed += AlarmElapse;
                    AlarmTime.Enabled = true;
                }

                else
                {
                    int HourTime = Math.Abs(hour - DateTime.Now.Hour);
                    int MinuteTime = Math.Abs(minute - DateTime.Now.Minute);

                    int TimeToNextAlarm = Math.Abs((HourTime * 60) + MinuteTime);
                    Console.WriteLine($"You have {HourTime} : {MinuteTime} time until Alarm");
                    Thread.Sleep(TimeToNextAlarm * 60000);
                }

            }

        }

        private void AlarmElapse(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Alarm is working.  For stop it press 'Esc' ");
        }



    }
}
