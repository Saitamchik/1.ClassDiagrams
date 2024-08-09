using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notify
{
    class SMSLowBalanceNotifyer : INotifyer
    {
        string _phone;
        decimal _lowBalanceValue;

        public SMSLowBalanceNotifyer(string phone, decimal lowBalanceValue)
        {
            _phone = phone;
            _lowBalanceValue = lowBalanceValue;
        }

        public void Notify(decimal balance)
        {
            string callingClassName = GetType().Name;
            Console.WriteLine($"The method is called from the class: {callingClassName}");

            if (balance < _lowBalanceValue)
            {
                Console.WriteLine("Balance: " + balance);
            }
        }
    }
}
