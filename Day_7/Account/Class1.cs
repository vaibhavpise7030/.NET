﻿

  //Create a class Account having private instance member Id, Name Balanceamt. 
  //Id should be generated by application. Create method deposit who’s job is to increase Balanceamtby 
  //the amout deposited by account holder. Create method withdraw who’s job is to decrease Balanceamt 
  //by the amount  withdrawn by account holder. Write method display which will display name and Balanceamt. 
  //Your application should create array of account class and store 3 object. Display name and balance
  

using System;

namespace ClassLibrary1
{
    public class Account
    {
        int id;
        string name;
        double balAmt;

        static int Id;

        static Account()
        {
            Console.WriteLine("Bank of India");
        }
        public Account(string name, double balAmt)
        {
            this.name = name;
            this.balAmt = balAmt;
            id = ++Id;
        }
        public void deposite(int amt)
        {
            balAmt += amt;
        }
        public void withdraw(int amt)
        {
            balAmt -= amt;
        }
        public void disp()
        {
            Console.WriteLine("{0}  {1} ", name, balAmt);
        }

    }

}