using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPS
{
    public class BankAccount
    {   
       // public event Action BankAccountCreatedEvent;

        public BankAccount() { }

        public void BankAccountCreated()
        {
            Console.WriteLine( "Bank account created successfully.");
        }

    }
}
