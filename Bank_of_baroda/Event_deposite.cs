using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_baroda
{
    public class Event_deposite
    {
        
            public static void Email1(int id, double Bal, string Na)
            {
                Console.WriteLine("email sent");
                Console.WriteLine("Ammout is deposite from ID:" + id + " Name of account holder : " + Na + " current balance is  :" + Bal);
            }

            public static void TextMsg1(int id, double Bal, string Na)
            {
                Console.WriteLine("message sent");
                Console.WriteLine("Ammout is deposite from  ID:" + id + " Name of account holder : " + Na + " current balance is  : " + Bal);
            }
        }
    }

