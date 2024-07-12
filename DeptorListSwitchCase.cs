using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dept_List_System
{
    
    internal class DeptorListSwitchCase
    {
        public static int DeptorLSCase(string choiceindeptorlist, List<string> debtorNames)
        {
            int switchCaseExiter = 0;
            while (true)
            {
                switch (choiceindeptorlist)
                {
                    case "0":
                        Console.WriteLine("TYPE THE FULLNAME OF THE DEBTOR SELECTED: ");
                        string SelectedDeptor = Console.ReadLine();
                        if (debtorNames.Contains(SelectedDeptor))
                        {
                            MenuFunction.UIDelay();
                            Console.WriteLine($"ACCESSING {SelectedDeptor} CREDITS");
                            MenuFunction.UIDelaywithText();

                            Console.WriteLine($"{SelectedDeptor}: ");
                            int creditListID = debtorNames.IndexOf(SelectedDeptor);
                            Credits.MainCreditMenu(creditListID, SelectedDeptor);

                            MenuFunction.UIDelay();
                            Console.WriteLine("GOING BACK TO MENU...");
                            switchCaseExiter = 1;
                            break;
                            

                        }
                        else
                        {
                            Console.WriteLine("THE DEBTOR IS NOT ON THE LIST.");
                            MenuFunction.UIDelay();
                            Console.WriteLine("GOING BACK TO MENU...");
                            switchCaseExiter = 1;
                            break;
                        }
                    case "1":
                        Console.Write("WRITE THE NAME OF THE NEW DEBTOR: ");
                        string newDeptor = Console.ReadLine();
                        MenuFunction.UIDelay();
                        debtorNames.Add(newDeptor);
                        Console.WriteLine($"ACCESSING {newDeptor} CREDITS");


                        Console.WriteLine($"{newDeptor}: ");
                        int creditListID1 = debtorNames.IndexOf(newDeptor);
                        Credits.MainCreditMenu(creditListID1, newDeptor);

                        MenuFunction.UIDelay();
                        Console.WriteLine("GOING BACK TO MENU...");
                        break;
                    case "2":
                        MenuFunction.UIDelay();
                        Console.WriteLine("GOING BACK TO MENU...");
                        Task.Delay(1500).Wait();
                        switchCaseExiter = 1;
                        break;
                    default:
                        break;
                }
                return switchCaseExiter;
            }
        }
    }
}
