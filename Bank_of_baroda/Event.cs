using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_of_baroda
{
    public class Events_withdraw
    {
        public static void Email(int i, double Bal, string Na)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("email sent");
            Console.WriteLine("Ammout is withdrawn from ID:" + i + " Name of account holder : " + Na + " current balance is  :" + Bal);
            
        }

        public static void TextMsg(int i, double Bal, string Na)
        {
          
            Console.WriteLine("message sent");
            Console.WriteLine("Ammout is withdrawn from  ID:" + i + " Name of account holder : " + Na + " current balance is  : " + Bal);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
