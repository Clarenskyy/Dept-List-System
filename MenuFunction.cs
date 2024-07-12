using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dept_List_System
{

    internal class MenuFunction
    {
        static List<string> debtorNames = new List<string>();
        private static void DeptorName()
        {
            debtorNames.Add("Larry");
            debtorNames.Add("Hannah");
            debtorNames.Add("Janjan");
        }
        public static void menuMain()
        {
            DeptorName();
            while (true)
            {
                //key variable that will exit the loop if needed
                int loopExiter = 0;
                Console.Clear();

                Console.Write("**WELCOME TO DEBT LIST SYSTEM!**" +
                              "\n|-----------------------------|" +
                              "\n| 1 | SEE LIST OF DEBTOR      |" +
                              "\n|-----------------------------|" +
                              "\n| 2 | LOGOUT                  |" +
                              "\n|-----------------------------|" +
                              "\n\tChoice (1-2): ");
                string choice = Console.ReadLine();
                loopExiter = SecondMenuInterface(choice);
                if (loopExiter != 0)
                {
                    break;
                }
            }
        }
        public static int SecondMenuInterface(string choice)
        {
            while (true) 
            {
             int loopExiter = 0;
                switch (choice)
                {
                 case "1":
                     string choiceindeptorlist = SeeListofDeptor();
                     int switchCaseExiter = DeptorListSwitchCase.DeptorLSCase(choiceindeptorlist, debtorNames);

                     if (switchCaseExiter != 0)
                        {
                            break;
                        }
                     else
                        {
                            continue;
                        }
                 case "2":
                     UIDelay();
                     Console.WriteLine("Log Out Successful!");
                     loopExiter = 1;
                     Task.Delay(1500).Wait();
                     break;
                 default:
                     Task.Delay(1500).Wait();
                     Console.WriteLine("Incorrect input, please choose between 1-2 only");
                     Task.Delay(4000).Wait();
                     Console.Clear();
                     break;
                }

                    return loopExiter;
            }   
        }
        public static string SeeListofDeptor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            UIDelay();
            Console.WriteLine("DEPT LIST SYSTEM\n");

            int numlist = 1;

            //Display the list of debtor names
            Console.WriteLine("         LIST OF DEBTORS:" +
                              "\n**-------------------------------**");
            foreach (var name in debtorNames)
            {
                Console.WriteLine($"| {numlist} | {name}      " +
                              "\n**-------------------------------**");
                numlist++;
            }
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n[0] SELECT A DEBTOR");
            Console.WriteLine("[1] ADD A DEBTOR");
            Console.WriteLine("[2] EXIT");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();
            Console.ResetColor();

            return choice;
        }
        public static void UIDelay()
        {
            Task.Delay(1000).Wait();
            Console.Clear();
        }
        public static void UIDelaywithText()
        {
            Task.Delay(1000).Wait();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+-----------------------------+\r\n|        Code by: Klay        |\r\n+-----------------------------+");
            Console.ResetColor();
            Console.WriteLine("Dept List System");
        }
    }
}
