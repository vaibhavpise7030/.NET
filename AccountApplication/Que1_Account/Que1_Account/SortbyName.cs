using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    class SortbyName : IComparer<Account>
    {

        public int Compare(Account x, Account y)
        {
            //return x.CNAME.CompareTo(y.CNAME);
            return string.Compare(x.CNAME,y.CNAME);
        }

    }
}