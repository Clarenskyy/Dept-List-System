using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dept_List_System
{
    internal class Credits
    {
        static double loopcounter = 0;
        static double loopcounter1 = 0;
        static double loopcounter2 = 0;
        static double loopcounter3 = 0;
        static double loopcounter4 = 0;
        static double balance = 0;
        static double balance1 = 0;
        static double balance2 = 0;
        static double balance3 = 0;
        static double balance4 = 0;
        static Dictionary<string, double> Debt001 = new Dictionary<string, double>();
        static Dictionary<string, double> Debt002 = new Dictionary<string, double>();
        static Dictionary<string, double> Debt003 = new Dictionary<string, double>();
        static Dictionary<string, double> Debt004 = new Dictionary<string, double>();
        static Dictionary<string, double> Debt005 = new Dictionary<string, double>();
        public static void MainCreditMenu(int creditListID, string SelectedDebtor)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("+-----------------------------+\r\n|        Code by: Klay        |\r\n+-----------------------------+");
                Console.ResetColor();
                int LooEpExitor = 0;
                double totalPrice = 0;
                if (creditListID == 0)
                {
                    (loopcounter, totalPrice) = DeptDisplayer1(loopcounter, SelectedDebtor);
                    loopcounter++;
                    LooEpExitor = CreditAdder1(LooEpExitor, totalPrice);
                }
                else if (creditListID == 1)
                {
                    (loopcounter1, totalPrice) = DeptDisplayer2(loopcounter1, SelectedDebtor);
                    loopcounter1++;
                    LooEpExitor = CreditAdder2(LooEpExitor, totalPrice);
                }
                else if (creditListID == 2)
                {
                    (loopcounter2, totalPrice) = DeptDisplayer3(loopcounter2, SelectedDebtor);
                    loopcounter2++;
                    LooEpExitor = CreditAdder3(LooEpExitor, totalPrice);
                }
                else if (creditListID == 3)
                {
                    (loopcounter3, totalPrice) = DeptDisplayer4(loopcounter3, SelectedDebtor);
                    loopcounter3++;
                    LooEpExitor = CreditAdder4(LooEpExitor, totalPrice);
                }
                else if (creditListID == 4)
                {
                    (loopcounter4, totalPrice) = DeptDisplayer5(loopcounter4, SelectedDebtor);
                    loopcounter4++;
                    LooEpExitor = CreditAdder5(LooEpExitor, totalPrice);
                }

                if (LooEpExitor != 0)
                {
                    break;
                }
            }

        }
        public static (double, double) DeptDisplayer1(double loopcounterr, string SelectedDebtor)
        {
            if (loopcounterr == 0)
            {
                Debt001.Add("Tang", 20.00);
                Debt001.Add("Coke mismo", 20.00);
                Debt001.Add("Coke 1.5", 72.00);
                Debt001.Add("surf", 6.50);
                Debt001.Add("cash", 1000);
            }
            Console.WriteLine("============================================================");
            Console.WriteLine($"* {SelectedDebtor} Credit List **");
            Console.WriteLine("============================================================");
            double totalPrice = 0;

            if (Debt001.Count == 0 && balance > 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
                totalPrice = balance;
                Console.WriteLine($"with balance: {totalPrice}"); 
            }
            else if (Debt001.Count == 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
            }
            else
            {
                foreach (var item in Debt001)
                {
                    Console.WriteLine($"{item.Key} - P{item.Value:0.00}");
                }

                Console.WriteLine("------------------------------------------------------------");
                if (balance > 0)
                {
                    Console.WriteLine($"Balance: {balance}");
                }
                totalPrice = Debt001.Sum(item => item.Value) + balance;
                
                Console.WriteLine($"Total: P{totalPrice:0.00}");
            }

            Console.WriteLine("============================================================");
            return (loopcounterr, totalPrice);
        }
        public static (double, double) DeptDisplayer2(double loopcounterr, string SelectedDebtor)
        {
            if (loopcounterr == 0)
            {
                Debt002.Add("Tang", 120.00);
                Debt002.Add("Coke mismo", 240.00);
                Debt002.Add("Coke 1.5", 144.00);
                Debt002.Add("surf", 39.00);
                Debt002.Add("cash", 2500);
            }
            Console.WriteLine("============================================================");
            Console.WriteLine($"* {SelectedDebtor} Credit List **");
            Console.WriteLine("============================================================");
            double totalPrice = 0;

            if (Debt002.Count == 0 && balance1 > 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
                totalPrice = balance1;
                Console.WriteLine($"with balance: {totalPrice}");
            }
            else if (Debt002.Count == 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
            }
            else
            {
                foreach (var item in Debt002)
                {
                    Console.WriteLine($"{item.Key} - P{item.Value:0.00}");
                }

                Console.WriteLine("------------------------------------------------------------");
                totalPrice = Debt002.Sum(item => item.Value) + balance1;
                if (balance1 > 0)
                {
                    Console.WriteLine($"Balance: {balance1}");
                }
                Console.WriteLine($"Total: P{totalPrice:0.00}");
                
            }

            Console.WriteLine("============================================================");
            return (loopcounterr, totalPrice);
        }
        public static (double, double) DeptDisplayer3(double loopcounterr, string SelectedDebtor)
        {
            if (loopcounterr == 0)
            {
                Debt003.Add("Tang", 20.00);
                Debt003.Add("Coke mismo", 20.00);
                Debt003.Add("Coke 1.5", 72.00);
                Debt003.Add("surf", 6.50);
                Debt003.Add("load", 105);
            }
            Console.WriteLine("============================================================");
            Console.WriteLine($"* {SelectedDebtor} Credit List **");
            Console.WriteLine("============================================================");
            double totalPrice = 0;

            if (Debt003.Count == 0 && balance2 > 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
                totalPrice = balance2;
                Console.WriteLine($"with balance: {totalPrice}");
            }
            else if (Debt003.Count == 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
            }
            else
            {
                foreach (var item in Debt003)
                {
                    Console.WriteLine($"{item.Key} - P{item.Value:0.00}");
                }

                Console.WriteLine("------------------------------------------------------------");
                totalPrice = Debt003.Sum(item => item.Value) + balance2;
                if (balance2 > 0)
                {
                    Console.WriteLine($"Balance: {balance2}");
                }
                Console.WriteLine($"Total: P{totalPrice:0.00}");
                
            }

            Console.WriteLine("============================================================");
            return (loopcounterr, totalPrice);
        }
        public static (double, double) DeptDisplayer4(double loopcounterr, string SelectedDebtor)
        {

            Console.WriteLine("============================================================");
            Console.WriteLine($"* {SelectedDebtor} Credit List **");
            Console.WriteLine("============================================================");
            double totalPrice = 0;

            if (Debt004.Count == 0 && balance3 > 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
                totalPrice = balance3;
                Console.WriteLine($"with balance: {totalPrice}");
            }
            else if (Debt004.Count == 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
            }
            else
            {
                foreach (var item in Debt004)
                {
                    Console.WriteLine($"{item.Key} - P{item.Value:0.00}");
                }

                Console.WriteLine("------------------------------------------------------------");
                totalPrice = Debt004.Sum(item => item.Value) + balance3;
                if (balance3 > 0)
                {
                    Console.WriteLine($"Balance: {balance3}");
                }
                Console.WriteLine($"Total: P{totalPrice:0.00}");
                
            }

            Console.WriteLine("============================================================");
            return (loopcounterr, totalPrice);
        }
        public static (double, double) DeptDisplayer5(double loopcounterr, string SelectedDebtor)
        {

            Console.WriteLine("============================================================");
            Console.WriteLine($"* {SelectedDebtor} Credit List **");
            Console.WriteLine("============================================================");
            double totalPrice = 0;

            if (Debt005.Count == 0 && balance4 > 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
                totalPrice = balance4;
                Console.WriteLine($"with balance: {totalPrice}");
            }
            else if (Debt005.Count == 0)
            {
                Console.WriteLine("No credits for this debtor yet.");
            }
            else
            {
                foreach (var item in Debt005)
                {
                    Console.WriteLine($"{item.Key} - P{item.Value:0.00}");
                }

                Console.WriteLine("------------------------------------------------------------");
                totalPrice = Debt005.Sum(item => item.Value) + balance4;
                if (balance4 > 0)
                {
                    Console.WriteLine($"Balance: {balance4}");
                }
                Console.WriteLine($"Total: P{totalPrice:0.00}");
                
            }

            Console.WriteLine("============================================================");
            return (loopcounterr, totalPrice);
        }
        public static int CreditAdder1(int LooEpExitor, double totalPrice)
        {
            Console.WriteLine("\n[ADD CREDIT (0)]    [PAY CREDIT (1)]    [EXIT (2)]");
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    while (true)
                    {
                        Console.Write("Product Name: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        string productName = Console.ReadLine();
                        Console.ResetColor();
                        if (Debt001.ContainsKey(productName))
                        {
                            productName = productName + " ";
                        }
                        Console.Write("Price: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.ResetColor();
                        Debt001.Add(productName, productPrice);
                        Console.Clear();
                        break;
                    }
                    break;
                case 1:
                    Console.Write("Partial or Full? (p/f): ");
                    string paymentchoice = Console.ReadLine();
                    if (paymentchoice == "f")
                    {
                        Debt001.Clear();
                        balance = 0;
                        Console.WriteLine("Credit Paid!");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write("How much was paid: ");
                        double partialpay = Convert.ToDouble(Console.ReadLine());
                        balance = totalPrice - partialpay;
                        Debt001.Clear();
                        Console.Clear();
                        break;
                    }

                case 2:
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    LooEpExitor = 1;
                    break;
            }
            return LooEpExitor;
        }
        public static int CreditAdder2(int LooEpExitor, double totalPrice)
        {
            Console.WriteLine("[Add a credit (0)]    [pay credit (1)]    [exit (2)]");
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    while (true)
                    {
                        Console.WriteLine("Make sure that the product name is unique");
                        Console.Write("Product Name: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        string productName = Console.ReadLine();
                        Console.ResetColor();
                        if (Debt002.ContainsKey(productName))
                        {
                            productName = productName + " ";
                        }
                        Console.Write("Price: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.ResetColor();

                        Debt002.Add(productName, productPrice);
                        Console.Clear();
                        break;

                    }
                    break;
                case 1:
                    Console.Write("Partial or Full? (p/f): ");
                    string paymentchoice = Console.ReadLine();
                    if (paymentchoice == "f")
                    {
                        Debt002.Clear();
                        balance1 = 0;
                        Console.WriteLine("Credit Paid!");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write("How much was paid: ");
                        double partialpay = Convert.ToDouble(Console.ReadLine());
                        balance1 = totalPrice - partialpay;
                        Debt002.Clear();
                        Console.Clear();
                        break;
                    }

                case 2:
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    LooEpExitor = 1;
                    break;
            }
            return LooEpExitor;
        }
        public static int CreditAdder3(int LooEpExitor, double totalPrice)
        {
            Console.WriteLine("[Add a credit (0)]    [pay credit (1)]    [exit (2)]");
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    while (true)
                    {
                        Console.WriteLine("Make sure that the product name is unique");
                        Console.Write("Product Name: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        string productName = Console.ReadLine();
                        Console.ResetColor();
                        if (Debt003.ContainsKey(productName))
                        {
                            productName = productName + " ";
                        }
                        Console.Write("Price: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.ResetColor();

                        Debt003.Add(productName, productPrice);
                        Console.Clear();
                        break;
                    }
                    break;
                case 1:
                    Console.Write("Partial or Full? (p/f): ");
                    string paymentchoice = Console.ReadLine();
                    if (paymentchoice == "f")
                    {
                        Debt003.Clear();
                        balance2 = 0;
                        Console.WriteLine("Credit Paid!");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write("How much was paid: ");
                        double partialpay = Convert.ToDouble(Console.ReadLine());
                        balance2 = totalPrice - partialpay;
                        Debt003.Clear();
                        Console.Clear();
                        break;
                    }

                case 2:
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    LooEpExitor = 1;
                    break;
            }
            return LooEpExitor;
        }
        public static int CreditAdder4(int LooEpExitor, double totalPrice)
        {
            Console.WriteLine("[Add a credit (0)]    [pay credit (1)]    [exit (2)]");
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    while (true)
                    {
                        Console.WriteLine("Make sure that the product name is unique");
                        Console.Write("Product Name: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        string productName = Console.ReadLine();
                        Console.ResetColor();
                        if (Debt004.ContainsKey(productName))
                        {
                            productName = productName + " ";
                        }
                        Console.Write("Price: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.ResetColor();

                        Debt004.Add(productName, productPrice);
                        Console.Clear();
                        break;

                    }
                    break;
                case 1:
                    Console.Write("Partial or Full? (p/f): ");
                    string paymentchoice = Console.ReadLine();
                    if (paymentchoice == "f")
                    {
                        Debt004.Clear();
                        balance3 = 0;
                        Console.WriteLine("Credit Paid!");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write("How much was paid: ");
                        double partialpay = Convert.ToDouble(Console.ReadLine());
                        balance3 = totalPrice - partialpay;
                        Debt004.Clear();
                        Console.Clear();
                        break;
                    }

                case 2:
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    LooEpExitor = 1;
                    break;
            }
            return LooEpExitor;
        }
        public static int CreditAdder5(int LooEpExitor, double totalPrice)
        {
            Console.WriteLine("[Add a credit (0)]    [pay credit (1)]    [exit (2)]");
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    while (true)
                    {
                        Console.WriteLine("Make sure that the product name is unique");
                        Console.Write("Product Name: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        string productName = Console.ReadLine();
                        Console.ResetColor();
                        if (Debt005.ContainsKey(productName))
                        {
                            productName = productName + " ";
                        }
                        Console.Write("Price: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.ResetColor();

                        Debt005.Add(productName, productPrice);
                        Console.Clear();
                        break;

                    }
                    break;
                case 1:
                    Console.Write("Partial or Full? (p/f): ");
                    string paymentchoice = Console.ReadLine();
                    if (paymentchoice == "f")
                    {
                        Debt005.Clear();
                        balance4 = 0;
                        Console.WriteLine("Credit Paid!");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write("How much was paid: ");
                        double partialpay = Convert.ToDouble(Console.ReadLine());
                        balance4 = totalPrice - partialpay;
                        Debt005.Clear();
                        Console.Clear();
                        break;
                    }

                case 2:
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    LooEpExitor = 1;
                    break;
            }
            return LooEpExitor;
        }

    }
}

