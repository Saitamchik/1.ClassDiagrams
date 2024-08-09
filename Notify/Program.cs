using System.Security.Principal;

namespace Notify
{
    public class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(10000);
            SMSLowBalanceNotifyer smsNotifier = new SMSLowBalanceNotifyer("+79000000000", 300);
            EMailBalanceChangedNotifyer emailNotifier = new EMailBalanceChangedNotifyer("example@gmail.com");

            account.AddNotifier(smsNotifier);
            account.AddNotifier(emailNotifier);
            account.ChangeBalance(900);
            Console.WriteLine("-----------------------");
            account.ChangeBalance(200);
        }
    }
}