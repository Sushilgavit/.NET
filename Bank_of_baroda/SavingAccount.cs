using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_baroda
{
  public class SavingAccount : Account
    {
        static double RateOFinntrest = 0.70;
        public  SavingAccount(String Name ,Double Balance) : base(Name , Balance ) { }

        

        public override void withdraw(double Amount)
        {
            double bal = Balance - Amount;
            if (bal > minbalance)
            { Balance -= Amount;
                OnWithdraw(ID, Balance, Name);
               
            }
            else 
                throw new Exception("balance is less than min balance");


             
        }

        public static Double PayIntrest(SavingAccount ref1)
        {
            double Intrest = ref1.Balance*RateOFinntrest;
            ref1.Balance += Intrest;
            return Intrest;
        }
    }
}
