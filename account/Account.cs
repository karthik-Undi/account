using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class Account
    {
        private int id;
        private String accountType;
        private Double balance;
        public int ID   // property
        {
            get { return id; }
            set { id = value; }
        }
        public String AccountType   // property
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public Double Balance  // property
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Account() { }
        public Account(int id,String accountType,Double balance)
        {
            this.accountType = accountType;
            this.id = id;
            this.balance = balance;
        }
        public Boolean Withdraw(Double amt)
        {

            if (amt > balance) 
            {
                Console.WriteLine("Insufficient Funds");
                return false;
            }
            else
            {
                balance = balance - amt;
                return true;
            }
            
        }
        public Boolean Deposit(Double amt)
        {
            balance = balance + amt;
            return true;
        }

        public  void GetDetails()
        {
            Console.WriteLine("Account ID : " + ID + "\nAccount Type : " + AccountType + "\nBalance : " + Balance);
        }


    }
}
