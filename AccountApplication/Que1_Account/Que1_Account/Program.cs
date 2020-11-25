using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Que1_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Saving s1 = new Saving("Akash", 50000);
                Saving s2 = new Saving("Ganesh", 40000);
                Saving s3 = new Saving("Rohit", 10000);
                Current c1 = new Current("Vaibhav", 35000);
                Current c2 = new Current("Anand", 45000);
                //Current c3 = new Current("Patil", 60000);// Throw expection

                List<Account> accounts = new List<Account>();
                accounts.Add(s1);
                accounts.Add(s2);
                accounts.Add(s3);
                accounts.Add(c1);
                accounts.Add(c2);

                MsgAndEmail msg = new MsgAndEmail();

                foreach (Account ac in accounts)
                {
                    ac.MyEvent += msg.Email;
                    ac.MyEvent += msg.Msg;
                }

                //s2.Withdraw(1000);
                
                /*
                Console.WriteLine("Sort By Name");
                accounts.Sort(new SortbyName());
                foreach (Account ac in accounts)
                {
                    Console.WriteLine(ac.ToString());
                }
                 */

                //var a =from rng in accounts where rng.GetBalance()== (from p in accounts select p.GetBalance()).Max() select rng;
                //foreach (Account ac in a)
                //{
                //    Console.WriteLine(ac.ToString());
                //}

                //var b = from rng in accounts where rng.CNAME.StartsWith("A") select rng;
                //foreach (Account ac in b)
                //{
                //    Console.WriteLine(ac.ToString());
                //}

                //var c = from rng in accounts where rng.GetBalance() > 40000 select rng;
                //foreach (Account ac in c)
                //{
                //    Console.WriteLine(ac.ToString());
                //}

                //var d = from rng in accounts where rng.GetBalance() < 20000 select rng;
                //foreach (Account ac in d)
                //{
                //    Console.WriteLine(ac.ToString());
                //}

                //var e = from rng in accounts select rng;
                //foreach (Account ac in e)
                //{
                //    Console.WriteLine(ac.ToString());
                //}

                //var f = from rng in accounts group rng by rng.Type into rng select rng;
                //foreach (var ac in f)
                //{
                //    Console.WriteLine("\n"+ac.Key);

                //    foreach (Account a in ac)
                //    {
                //        Console.WriteLine(a.ToString());
                //    }
                //}

                //var g = (from rng in accounts select rng.GetBalance()).Min();
                //Console.WriteLine(g);
                //var h = (from rng in accounts select rng.GetBalance()).Max();
                //Console.WriteLine(h);

                //Anonymous Object LINQ

                var k = from rng in accounts select new { Id = rng.CID, Name = rng.CNAME };
                foreach (var a in k)
                    {
                        Console.WriteLine(a);
                    }

            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

          

            Console.Read();
        }
    }
}
