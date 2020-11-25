using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    class MsgAndEmail
    {
        public void Email(string name, double bal, double wamt)
        {
 
            Console.WriteLine("Email : Hii {0} {1} is Debited from your Account now Available balance is {2}",name,bal,wamt);
        }

        public void Msg(string name, double bal, double wamt)
        {
            Console.WriteLine("Message : Hii {0} {1} is Debited from your Account now Available balance is {2}", name, bal, wamt);
        }
    }
}
