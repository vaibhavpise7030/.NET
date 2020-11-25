using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    class Saving : Account
    {
       
        
        public Saving (string Name, double Balance): base (Name,Balance,"Saving")
        {
        }

        public override void Withdraw(double amt)
        {
            const int MinBalance = 1000;
            double CheckAmount = CBALANCE-amt;

            if (CheckAmount < MinBalance)
            {
                throw new MyException(CID,CNAME,CBALANCE,"Insufficient Balance");
            }

            else
            {
                CBALANCE -= amt;
                Notification(CNAME,CBALANCE,amt);
            }

        }

        static public string  payinterest(Account ob1)
        {
            Saving ob = (Saving)ob1;
            double ROI=0.08;
            double add = ob.CBALANCE * ROI;
            ob.CBALANCE += add;
            return "Intreste Amount: "+ob.CBALANCE;
        }

        public override string ToString()
        {
            return string.Format("ID : {0},Name : {1}, Balance : {2}", CID, CNAME, CBALANCE);
        }
    }
}
