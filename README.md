READ ME!!

Created by: 
Dela Cruz, Clarence Kieth M. BSCPE 1-1

This code contains a program that works as a debt or credit list for convenient stores with debtors.

[Program.cs] - containes simple user interface that tells the user what type of program is being run. It also calls the LoginLoop method from the LoginAndAcc.cs class. it contains an integer variable validation that when the user fails to log in the program ends, and if they don't the program will proceed and call the menuMain method from the MenuFunction.cs class.

[LoginAndAcc.cs] - Totaling 4 methods (Usernames{declares username and password}, getPassword{ask the user to input a password and username}, LoginLoop{the main method of the login function this checks the inputted username and password}, and DisplayAttemptLeft{}) this class utilizes while loop, if else, and dictionary to imitate a login function that gives you 3 attempts if ever the user made a mistake in logging in. 

[MenuFunction.cs] - his program keeps track of credit information for debtors. It allows users to:
See a list of debtors with their credit details.  Potentially manage credits for a chosen debtor (e.g., add new credit items, pay existing credits).
User Interface: The program offers a user-friendly menu system for navigation. Main Menu: See a list of debtors, and Logout. In the Debtor List Menu: (accessible from the main menu) View details of a specific debtor, Add a new debtor, and Exit.

[DeptorListSwitchCase.cs] - 
This code handles selections within the "See List of Debtor" menu. It lets you: Select a debtor (choice 0) - to manage their credits (calls another function). Add a new debtor (choice 1) - and manage their credits too. Exit (choice 2).


[Credit.cs] - This class manages credit for individual debtors. It stores credit information (item name and price) for each debtor in separate dictionaries (Debt001, Debt002, etc.).
How it works:
The user selects a debtor from the "See List of Debtors" menu.
The program identifies the debtor and displays their credit list, including item details, total price, and any existing balance.
The user can then:
(1) Add new credit items, (2) Pay existing credits (partially or fully), and (3) Exit.

