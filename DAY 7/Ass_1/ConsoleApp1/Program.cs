/*Create class Account having member id, name, balance.
Id autoincrement write read only property
Write getter setter for name and balance.
Balance can be modified only by child class.
This has virtual withdraw method which will 0.
It has deposit method.
Create two child class current and saving and override withdraw method. 
Create reference of Account class and point to saving account
and  current account. Using parent’s reference call withdraw method and deposit method.
Use ToString method to display status of the object [id name balance*/

using ConsoleApp1;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        static int id = 0;

        public int AccId { get; }

        string name;
        double balance;

        public Account(string name, double balance)
        {
            AccId = ++id;
            this.name = name;
            this.balance = balance;
        }

        public double ID
        {
            get { return AccId; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Name lenght should be less than 10");
                }
                else
                {
                    name = "sushil";
                }
            }
        }

        public double Balance
        {
            get { return balance; }
            protected set { balance =value; }
        }

        public virtual double withdraw(double balance)
        {
            return 0;
        }

        public double Diposit(double amount) { return balance += amount; }
        public string display()
        {
            return string.Format("{0} {1} {2}",id,name,balance);
        }

    }

    class current : Account
    {
    
        public current(string name, Double balance) : base(name, balance) { }
        {

        }
    public override double withdraw(double ammount)
    {
        return Balance -= ammount;
    }
    }

    class saving :Account
    {
        public saving(string name, Double balance)
        {

        }
    }

}


