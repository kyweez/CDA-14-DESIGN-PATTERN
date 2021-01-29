using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCommandPattern
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount Account
        {
            get; set;
        }

        public void Call()
        {
            throw new NotImplementedException();
        }
    }
}
