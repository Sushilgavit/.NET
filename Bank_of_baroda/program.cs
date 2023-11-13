using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_baroda
{
    public class program
    {
     
        static void Main(string[] args)
        {
            /* Account s1=new SavingAccount("SUSHIL" ,20000);
              Console.WriteLine(s1.ToString());
              s1.withdraw(500);

              s1.Deposite(1000);*/

           

            List<Account> accounts = new List<Account>();
            try
            { 
            accounts.Add(new SavingAccount("sushil", 20000));
                        }
            catch(Exception ex)  
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                accounts.Add(new SavingAccount("ajinkya", 30000));
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {


                accounts.Add(new SavingAccount("shubham", 25000));
             
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
            try
            {
                accounts.Add(new SavingAccount("Akshay", 26000));
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          

           for(int i=0;i<accounts.Count;i++)
  
            {
                Console.WriteLine(accounts[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            try
            {
                accounts[2].Deposite(2000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
            try
            {
                accounts[1].Deposite(6000);
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
            
            try
            {
                accounts[1].withdraw(6000);
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
            Console.WriteLine(accounts[2] + " After deposting intrest your updated Balance is " +SavingAccount.PayIntrest((SavingAccount)accounts[2]));
            Console.WriteLine(accounts[2]);
            Console.WriteLine(accounts[2]);
          
        }
    }
}
