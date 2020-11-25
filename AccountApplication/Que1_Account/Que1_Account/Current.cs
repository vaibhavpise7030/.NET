using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    class Current : Account
    {
        public Current (string Name, double Balance): base (Name,Balance,"Current")
        {
        }

        public override void Withdraw(double amt)
        {
            CBALANCE -= amt;
            Notification(CNAME, CBALANCE, amt);
        }

        static public  string collectIntrest(Account ob1)
        {
            Current ob = (Current)ob1;
            double ROI = 0.09;
            double add = ob.CBALANCE * ROI;

            if (ob.CBALANCE < 0)
            {
                ob.CBALANCE -= add;
            }
            return "Intreste Amount: "+ob.CBALANCE;
        }

        public override string ToString()
        {
            return string.Format("ID : {0},Name : {1}, Balance : {2}", CID, CNAME, CBALANCE);
        }


    }
}
