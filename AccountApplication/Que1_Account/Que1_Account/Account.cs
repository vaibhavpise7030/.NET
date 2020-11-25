using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    public delegate void MyDeligate(string name,double bal,double wamt);

    abstract class Account
    {
        public string Type;
        private int Id;
        static int AutoID;
        const int MaxCapacity = 5;

        public event MyDeligate MyEvent;

        static Account()
        {
            Console.WriteLine("Bank OF India\n");
        }

        public Account(string Name,double Salary,string type)
        {

            if (MaxCapacity < AutoID + 1)
            {
                throw new Exception("only 5 user allowed");
            }
            else
            {
                CNAME = Name;
                CBALANCE = Salary;
                CID = ++AutoID;
                this.Type = type;
            }
           
        }

        public int CID
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Name;

        public String CNAME
        {
            get { return Name; }
            set
            { 
                if (value.Length > 15)
                {
                    throw new Exception("Name should be less than 15 character");
                }
                else
                {
                    Name = value;
                }
            }
        }

        private double Balance;

        protected double CBALANCE
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public void Deposit(double amt)
        {
            CBALANCE += amt;

            Console.WriteLine("Amount depositted " + amt);
        }

        public void Notification(string name, double bal, double wamt)
        {
            if (MyEvent != null)
            {
                MyEvent(name, bal, wamt);
            }
        }

        public double GetBalance()
        {
            return CBALANCE;
        }

        public abstract void Withdraw(double amt);

    }
}
