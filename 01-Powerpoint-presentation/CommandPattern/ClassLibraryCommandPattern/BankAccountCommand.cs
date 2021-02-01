using System;

namespace ClassLibraryCommandPattern
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount Account
        {
            get; set;
        }

        private EnumAction Action
        {
            get; set;
        }

        private int Amount
        {
            get; set;
        }

        public bool SucceedFlag
        {
            get; private set;
        }

        public BankAccountCommand(BankAccount _account, EnumAction _action, int _amount)
        {
            Account = _account ?? throw new ArgumentNullException(paramName: "_account");
            Action = _action;
            if (_amount > 0)
                Amount = _amount;
            else
                Amount = 0;

        }

        public void Call()
        {
            switch (Action)
            {
                case EnumAction.Deposit:
                    SucceedFlag = Account.Deposit(Amount);
                    break;
                case EnumAction.Withdraw:
                    SucceedFlag = Account.Withdraw(Amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            switch (Action)
            {
                case EnumAction.Deposit:
                    Account.Withdraw(Amount);
                    break;
                case EnumAction.Withdraw:
                    Account.Deposit(Amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}