using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Message
    {
        private int AM;
        private int PM;
        private int night;

        /**
         * COnstructeur qui initialise l'objet avec des valeurs par défaut
         * */
        public Message()
        {
            AM = 9;
            PM = 13;
            night = 18;
        }

        /**
               * pour tester le bon fonctionnement on crée une nouvelle 
               * instance de DateTtime à laquelle on donne une date en dur
               * par exemple jour un weekend
               *  DateTime dt = new DateTime(2018, 6, 17);
               *  On remplacerait alors DateTime.Now par dt dans les ifs / else 
               * 
               * */
        //{0} {1} {2} {3}  {5} {6}correspont dans l'ordre à DateTime.Now.DayOfWeek, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute

        // (ReadLine() > lit les entrées clavier >> console.ReadLine() )
        //le do while ci dessous indique que tant que l'utilisateur ne tape pas "exit" + ENTER
        //On affiche le le message correspondant 
        public void GetHelloMessage()
        {
            do
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    BonWE();
                }
                else
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < AM || DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > night)
                    {
                        BonWE();
                    }
                    else
                    {
                        if (DateTime.Now.Hour < AM && DateTime.Now.Hour > night)
                        {
                            Bonsoir();
                        }
                        else
                        {
                            if (DateTime.Now.Hour > AM && DateTime.Now.Hour < PM)
                            {
                                Bonjour();
                            }
                            else
                            {
                                BonAprem();
                            }
                        }
                    }

                    ReadKey();
                }
            } while (ReadLine() != "exit");
        }

        

        public void Bonjour()
        {
            WriteLine("Bonjour " + Environment.UserDomainName);
        }

        public void Bonsoir()
        {
            WriteLine("Bonsoir " + Environment.UserDomainName);
        }

        public void BonAprem()
        {
            WriteLine("Bon après midi  " + Environment.UserDomainName);
        }

        public void BonWE()
        {
            WriteLine("Bon week-end  " + Environment.UserDomainName);
        }
    }
}
