using System.Collections.Generic;

namespace Dept_List_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+-----------------------------+\r\n|        Code by: Klay        |\r\n+-----------------------------+");
            Console.ResetColor();
            Console.WriteLine("** WELCOME TO DEBT LIST SYSTEM **");
            Console.WriteLine("       LOGIN TO PROCEED\n");
            int validation = LoginAndAcc.LoginLoop();

            if (validation == 0)
            {
                return;
            }

            Task.Delay(1000).Wait();

            MenuFunction.menuMain();

            //done - posible removal of credit item memo, instead just focus on being able to add items in the dictionary. we will use list.sum to sum the credit
            //done - possible limit on the number of debtors to be added in the debtor list
            //done - once a credit is reduced all the items in the list will be removed and will display the remaining balance if there is any
            //done - errors: when exiting from the credit list it double declares
            //cant do anything about it - cant add the same price or same name
            //done - add deptor function
            //error removed - error 3 can only do all the functions on debtor 1
            
        }
    }
}
