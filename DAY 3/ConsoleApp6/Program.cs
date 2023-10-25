using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           account a=new account("sachin" , 01 ,300000);
            account a2 = new account("tushar", 02, 400000);
            a.withdraw(10000);
            a2.deposit(50000);
            a.display();
            a2.display();

        }
    }
}
