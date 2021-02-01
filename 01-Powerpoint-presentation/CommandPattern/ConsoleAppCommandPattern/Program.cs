using ClassLibraryCommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account_1 = new BankAccount(1000, -100);
            List<BankAccountCommand> commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(account_1, EnumAction.Withdraw, 1050),
                new BankAccountCommand(account_1, EnumAction.Deposit, 100),
                new BankAccountCommand(account_1, EnumAction.Withdraw, 500)
            };

            // Account creation
            Console.WriteLine("Initializing a bank account with 1050 $ and -100 $ of overdraft limit :");
            Console.WriteLine("_______________________________________________________________________\n");
            Console.WriteLine($"{account_1}");
            Console.WriteLine("Press any key to continue\n");
            Console.ReadKey();

            // Applying commands
            Console.WriteLine("Applying a list of commands on the bank account :");
            Console.WriteLine("_________________________________________________\n");
            foreach (BankAccountCommand c in commands)
            {
                Console.WriteLine("Processing the command...");
                c.Call();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            // Undoing commands
            Console.WriteLine("Undoing the previous commands on the bank account :");
            Console.WriteLine("___________________________________________________\n");
            foreach (BankAccountCommand c in Enumerable.Reverse(commands))
            {
                Console.WriteLine("Processing the undoing command...");
                c.Undo();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }
    }
}