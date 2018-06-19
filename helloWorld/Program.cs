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
            WriteLine("Nous sommes {0} {1} {2} {3} , il est {4} : {5}", DateTime.Now.DayOfWeek, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute);
            msg.GetHelloMessage();
        }

    }
}
