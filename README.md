READ ME!!

Created by: 
Dela Cruz, Clarence Kieth M. BSCPE 1-1

This code contains a program that works as a debt or credit list for convenient stores with debtors.

[Program.cs] - containes simple user interface that tells the user what type of program is being run. It also calls the LoginLoop method from the LoginAndAcc.cs class. it contains an integer variable validation that when the user fails to log in the program ends, and if they don't the program will proceed and call the menuMain method from the MenuFunction.cs class.

[LoginAndAcc.cs] - Totaling 4 methods (Usernames{declares username and password}, getPassword{ask the user to input a password and username}, LoginLoop{the main method of the login function this checks the inputted username and password}, and DisplayAttemptLeft{}) this class utilizes while loop, if else, and dictionary to imitate a login function that gives you 3 attempts if ever the user made a mistake in logging in. 

[MenuFunction.cs] - This class contains all the functionalities related to the user interface and menu system. It offers a menu with options to view or logout. It validates user choices and displays the debtor list if requested.

[DeptorListSwitchCase.cs] - This class handles selections within the "See List of Debtor" menu. It lets you: Select a debtor (choice 0) - to manage their credits (calls another function). Add a new debtor (choice 1) - and manage their credits too. Exit (choice 2).

[Credit.cs] - Program tracks credits for debtors using dictionaries. User selects a debtor, sees list of credits and can add new ones, pay existing ones, or exit. Separate functions handle each debtor for future scalability.

