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
        

        /**
               * pour tester le bon fonctionnement on crée une nouvelle 
               * instance de DateTtime à laquelle on donne une date en dur
               * par exemple jour un weekend
               *  DateTime dtNow = new DateTime(2018, 6, 17);
               *  On remplacerait alors DateTime.Now par dtNow dans les ifs / else 
               * 
               * */

        // (ReadLine() > lit les entrées clavier >> console.ReadLine() )
        //le do while ci dessous indique que tant que l'utilisateur ne tape pas "exit" + ENTER
        //On affiche le le message correspondant 

        private int AM;
        private int PM;
        private int night;

        /**
         * COnstructeur qui initialise l'objet avec des valeurs par défaut
         * */
        public Message(int AM =9, int PM=13, int night=18)
        {
            this.AM=AM;
            this.PM=PM;
            this.night=night;
        }

        public String GetHelloMessage()
        {
            DateTime dtTest = new DateTime(2018, 6, 18, 10, 0, 0);
            DateTime dtNow = DateTime.Now;
            
                if (dtNow.DayOfWeek == DayOfWeek.Saturday 
                    || dtNow.DayOfWeek == DayOfWeek.Sunday 
                    || dtNow.DayOfWeek == DayOfWeek.Monday && dtNow.Hour < AM 
                    || dtNow.DayOfWeek == DayOfWeek.Friday && dtNow.Hour > night)
                {
                   return "Bon weekend";
                }
                else if (dtNow.Hour < AM && dtNow.Hour > night)
                        {
                            return "Bonsoir" ;
                }
                 else if (dtNow.Hour >= AM && dtNow.Hour <= PM)
                         {
                          return "Bon matin";
                 }
                  else
                      {
                       return "Bon après midi";
                  }
          
        }

      /**  public void Bonjour()
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
        }*/
    }
}
