﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notify
{
    class EMailBalanceChangedNotifyer : INotifyer
    {
        string _email;

        public EMailBalanceChangedNotifyer(string email)
        {
            _email = email;
        }

        public void Notify(decimal balance)
        {
            string callingClassName = GetType().Name;
            Console.WriteLine($"The method is called from the class: {callingClassName}");
            Console.WriteLine("Balance: " + balance);
        }
    }
}
