using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server_Project
{


    internal class Server
    {
        List<string> Ap = new List<string>();
        String a = "ant";
        string b = "ball";
        String c = "cat";
        List<string> smsg = new List<string>();
        public void Sendc1()
        {
            Console.WriteLine("enter client 1 msg.... : ");
            string msg = Console.ReadLine();
            smsg.Add(msg);



        }
        public void sendc2()
        {
            Console.WriteLine("enter client 2 msg.... : ");
            string msg = Console.ReadLine();
            smsg.Add(msg);

        }
        public void dplay()
        {
            Console.WriteLine("chat history of client 1 and client 2 : ");
            foreach (string s in smsg)
            {
                Console.WriteLine(s);


            }
            string k = smsg[0];
            string v = smsg[1];
            Console.WriteLine("msg frm client 1 " + k);
            Console.WriteLine("msg frm client 2 " + v);
            Console.Read();

        }
        public void CH()
        {
            Console.WriteLine("if you want chat history press\"1\" press\"2\" for continue");
            string a = Console.ReadLine();
            if (a == "1")
            {

                dplay();

            }
            else
            {
                Console.WriteLine(" thank you ");
            }

        }
        public void List()
        {
            Ap.Add(a);
            Ap.Add(b);
            Ap.Add(c);
            foreach (string s in Ap)
            {
                Console.WriteLine(s);

            }
            Console.Read();
        }
        public void ra()
        {
            Ap.Remove(a);
            foreach (string s in Ap)
            {
                Console.WriteLine(s);


            }
            Console.Read();



        }
        public void rb()
        {
            Ap.Remove(b);
            foreach (string s in Ap)
            {
                Console.WriteLine(s);

            }
            Console.Read();


        }
        public void rc()
        {
            Ap.Remove(c);
            foreach (string s in Ap)
            {
                Console.WriteLine(s);

            }
            Console.Read();


        }
        public void createGrp()
        {
            Console.WriteLine("enter the grp name");
            string Grpname = Console.ReadLine();

            Console.WriteLine("please enter \"1\"for remove,\"2\"for edit grp name,\"3\"for change grp icon\" ");
            string num = Console.ReadLine();
            if (num == "1")
            {
                Console.WriteLine("please enter \"1\"to remove ant,\"2\"to remove ball,\"3\"for remove cat");
                string num1 = Console.ReadLine();
                if (num1 == "1")
                {
                    List();
                    Console.WriteLine("ant is removed :");
                    ra();
                }
                else if (num == "2")
                {
                    List();
                    Console.WriteLine("ball is removed :");

                    rb();
                }
                else if (num == "3")
                {
                    List();
                    Console.WriteLine("cat is removed :");
                    rc();
                }
                else
                {
                    List();

                }



            }
            else if (num == "2")
            {
                Console.WriteLine("enter new grp name");
                string newgrp = Console.ReadLine();
                Console.WriteLine("grp name updated");
            }
            else if (num == "3")
            {
                Console.WriteLine("insert your new icon");
                Console.WriteLine("grp icon updated");
            }
            else
            {
                Console.WriteLine("thankyou");

            }

        }


    }
}
