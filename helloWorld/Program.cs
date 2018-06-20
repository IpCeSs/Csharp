using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Message msg = new Message();
                    //{0} {1} {2} {3}  {5} {6}correspont dans l'ordre à DateTime.Now.DayOfWeek, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute

            WriteLine($"Nous sommes { DateTime.Now.DayOfWeek} {DateTime.Now.Day} {DateTime.Now.Month} { DateTime.Now.Year} , il est : {DateTime.Now.TimeOfDay.ToString().Substring(0,8)}");
           // msg.GetHelloMessage();
           do
            {
            WriteLine(msg.GetHelloMessage() +" "+ Environment.UserDomainName);
            ReadLine();
           }
          while (ReadLine() != "exit");
        }
    }
}
