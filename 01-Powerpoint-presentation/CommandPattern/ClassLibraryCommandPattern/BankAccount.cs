using System;

namespace ClassLibraryCommandPattern
{
    public class BankAccount
    {
        private int Balance
        {
            get; set;
        }

        private int AuthorizedOverdraft
        {
            get; set;
        }

        public BankAccount(int _amount, int _overdraft)
        {
            if (_amount < 0)
                Balance = 0;
            else
                Balance = _amount;
            if (_overdraft > 0)
                AuthorizedOverdraft = 0;
            else
                AuthorizedOverdraft = _overdraft;
        }

        public BankAccount(int _amount) : this(_amount, 0)
        {
            if (_amount < 0)
                Balance = 0;
            else
                Balance = _amount;
        }

        public BankAccount() : this(0)
        {
        }

        public bool Deposit(int _amount)
        {
            if (_amount < 1)
                return false;
            else
                Balance += _amount;
            Console.WriteLine($"Deposited : {_amount} $\nNew balance : {Balance}");
            return true;
        }

        public bool Withdraw(int _amount)
        {
            if (Balance - _amount < AuthorizedOverdraft)
            {
                Console.WriteLine($"You can't withdraw {_amount} $ because your overdraft limit is set to {AuthorizedOverdraft} $");
                return false;
            }
            else
            {
                Balance -= _amount;
                Console.WriteLine($"Withdrew : {_amount} $\nNew balance : {Balance}");
                return true;
            }
        }
    }
}
