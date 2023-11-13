using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_baroda
{
    public delegate void MyEventHandler(int i, double Bal, string Na);
    public abstract class Account
    {
        public event MyEventHandler SomeEventHandler;
        public event MyEventHandler SomeEventHandler1;
        static int getid = 0;
        int Id;
        protected string name;
        double balance;
        public const double minbalance = 1000;

        static Account()
        {
           
            Console.WriteLine("welcome to the bank of baroda");
        }


        public Account( string name, double balance)
        {
               if(getid<5)
            {
                this.name = name;
                this.Balance = balance;
                Id = ++getid;

            }
            else
            {
                throw new Exception("cant create more object");
            }


        }
        public int ID { get { return Id; } }




        public String Name
        {
            set
            {
                if (value.Length >2  && value.Length < 15)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        protected double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public abstract void withdraw(double Amount);

       
        public void Deposite(double Amount)

        {if (Amount > 0)
            balance += Amount;
            OnDiposite(Id, Balance, Name);
            //Console.WriteLine("Account Id =" + Id + " " + Amount  +"  Deposited and updated Balance is " + Balance );
        }
        public override string ToString()
        {
            return ($"id ={ Id} name ={Name} balance ={balance}");
        }

        public void OnWithdraw(int id, double bal,string Na)

        {
            SomeEventHandler += Events_withdraw.Email;
            SomeEventHandler += Events_withdraw.TextMsg;

            if (SomeEventHandler != null)
                SomeEventHandler(id, bal, Na);

        }

        public void OnDiposite(int i, double bal,string Na)
        {
            SomeEventHandler1 += Event_deposite.Email1;
            SomeEventHandler1+= Event_deposite.TextMsg1;
            if (SomeEventHandler1!= null)
                SomeEventHandler1(i, bal, Na);

        }

    }
}