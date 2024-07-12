﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dept_List_System
{
    internal class LoginAndAcc
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        private static void Usernames()
        {
            users.Add("Clarensky", "11111111");
            users.Add("Renzky", "11111111");
        }
        public static (string, string) getPassword()
        {
            Console.Write("Username: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Password: ");
            string enteredPassword = Console.ReadLine();

            return (enteredUsername, enteredPassword);

        }
        public static int LoginLoop()
        {
            string enteredUsername = "";
            string enteredPassword = "";
            Usernames();
            int validationValue = 0;

            int limit = 0;
            while ( limit < 4)
            {
                (enteredUsername, enteredPassword) = getPassword();
                if (users.ContainsKey(enteredUsername))
                {
                    // Get the password associated with the username
                    string storedPassword = users[enteredUsername];

                    // Compare entered password with stored password
                    if (enteredPassword == storedPassword)
                    {
                        Console.WriteLine("Login successful!");
                        validationValue = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password.");
                        validationValue = 0;
                        limit++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                    validationValue = 0;
                    limit++;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("+-----------------------------+\r\n|        Code by: Klay        |\r\n+-----------------------------+");
                Console.ResetColor();
                Console.WriteLine("** WELCOME TO DEBT LIST SYSTEM **\n");
                Console.WriteLine("LOGIN TO PROCEED\n");
                Console.WriteLine(DisplayAttemptLeft(limit));
                Console.WriteLine("====================");

            }
            return validationValue;

        }
        static string DisplayAttemptLeft(int limit)
            {
                string message = "";
                if (limit < 4)
                {
                    message = $"{limit}/3 attemps left.";
                }
                else
                {
                    message = $"Login Void, Too many attempts.";
                }
                return message;
            }

    }
}

