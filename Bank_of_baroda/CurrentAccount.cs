using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_baroda
{
     public class Current : Account
    {
        public Current(string name, double balance): base (name , balance) { }
        public override void withdraw(double Amount)
        {
            Balance-=Amount;
            OnWithdraw(ID , Amount,name); 
        }

        
    }
    
}
