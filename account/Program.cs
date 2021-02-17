using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class Program
    {
        public static List<Account> AccountList = new List<Account>();

        
        public static void RegisterAccount()
        {
            int Aid;
            String AccType="";
            Double AccBal=0,DPAmt=0,WDAmt=0;
            Console.WriteLine("Enter Your ID:");
            Aid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Account Type\n1.Savings\n2.Current\n3.Business");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    AccType = "Savings";
                    break;
                case 2:
                    AccType = "Current";
                    break;
                case 3:
                    AccType = "Business";
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }

            AccountList.Add(new Account(Aid, AccType, AccBal));
            int index = AccountList.FindIndex(Acc => Acc.ID == Aid);

            Console.WriteLine("Enter amount to Deposit: ");
            DPAmt = Convert.ToDouble(Console.ReadLine());
            AccountList[index].Deposit(DPAmt);
            
            Console.WriteLine("Enter amount to Withdraw: ");
            WDAmt = Convert.ToDouble(Console.ReadLine());
            AccountList[index].Withdraw(WDAmt);
            AccountList[index].GetDetails();
            Console.WriteLine("------------------------");

        }
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                RegisterAccount();
            }
        }
    }
}
