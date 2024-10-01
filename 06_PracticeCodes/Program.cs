using System;

class Program
{
    static void Main()
    {
        double balance = 1000;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Please choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n-------------------------------------------");
                    Console.WriteLine("Your balance is: $" + balance);
                    Console.WriteLine("-------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("\n-------------------------------------------");
                    Console.Write("Enter amount to deposit: $");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("Deposit successful! Your new balance is: $" + balance);
                    Console.WriteLine("-------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("\n-------------------------------------------");
                    Console.Write("Enter amount to withdraw: $");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrawal successful! Your new balance is: $" + balance);
                    }
                    Console.WriteLine("-------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("\n-------------------------------------------");
                    exit = true;
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    Console.WriteLine("-------------------------------------------");
                    break;
                default:
                    Console.WriteLine("\n-------------------------------------------");
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.WriteLine("-------------------------------------------");
                    break;
            }

            Console.WriteLine();
        }
    }
}
