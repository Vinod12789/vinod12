using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client();//C1 sending message from server
            Server s = new Server();// Server stores the login details of client and details of contacts(user defined values)
            Client C2 = new Client();//C2 acessing message from server



            Console.WriteLine(" select one option login or register");
            string abc = Console.ReadLine();
            if (abc == "login")
            {
                C1.Login();
            }
            else if (abc == "register")
            {
                C1.Registration();

            }
            else
            {
                Console.WriteLine("please select \"Login\" or \"register\" ");
            }
            Console.WriteLine("please enter \"1\"to create grp or press \"2\" to continue");
            string num2 = Console.ReadLine();

            if (num2 == "1")
            {
                s.createGrp();
            }
            else
            {
                Console.WriteLine("thankyou");
            }
            Console.Read();
            Console.WriteLine("send msg to client");



            s.Sendc1();
            s.sendc2();

            s.dplay();

            Console.Read();



        }
    }
}
