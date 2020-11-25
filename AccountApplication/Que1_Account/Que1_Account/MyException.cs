using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Que1_Account
{
    class MyException : ApplicationException
    {
        int id;
        string Name;
        double bal;
        public string msg;

        public MyException(int id, string Name, double bal,string msg)
        {
            this.id = id;
            this.Name = Name;
            this.bal = bal;
            this.msg = msg;

            string str=string.Format("ID : {0}, NAME : {1}, BALANCE : {2} ,Exception :{3}",this.id,this.Name,this.bal,this.msg);

            using (FileStream fs = new FileStream(this.Name + ".txt", FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(str);
                sw.Flush();
            }

        }
    }
}
