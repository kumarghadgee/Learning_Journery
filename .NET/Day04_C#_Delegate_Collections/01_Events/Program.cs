using System.Globalization;
using System.Security.Principal;

namespace _01_Events
{
    delegate void BalanceHandler(Account account,double amount);

    class Account
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public double Balance { get; set; }

        public event BalanceHandler LowBalance = null;

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Your Amount Deposited is {amount}.Total amount after deposite is {Balance}");
        }

        public void Withdraw(Account account, double amount)
        {
            if(amount > Balance)
            {
                if (LowBalance!=null)
                {
                    LowBalance(this, amount);
                }
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Your Amount Withdrawn is {amount}.After Withdrawal is {Balance}");
            }
        }

        public override string ToString()
        {
            return $"Id = {Id}, Type = {Type}, Balance = {Balance}";
        }
    }

    class Hdfc
    {
        public void SendLowBalanceSms(Account account,double amount)
        {
            string msg = $"Your Account {account} Balance is Insufficient.Your Given Amount is More{amount}";
            Console.WriteLine(msg);
        }

        public void TestTransaction()
        {
            Account acc = new Account() { Id = 1, Type = "Saving" , Balance = 3500.00};
            acc.LowBalance +=SendLowBalanceSms;
            acc.Deposit(500.00);
            Console.WriteLine(acc.Balance);
            acc.Withdraw(acc,2000.00);
            Console.WriteLine(acc.Balance);
            acc.Withdraw(acc,3400.00);
            Console.WriteLine(acc.Balance);
        }
    }

    class Citi
    {
        public void SendLowBalanceSms(Account accout,double amount)
        {
            string msg = $"Your Account {accout} Balance is Insufficient.Your Given Amount is More{amount}";
            Console.WriteLine(msg);
        }

        public void SendLowBalanceEmail(Account account,double amount)
        {
            string msg1 = $"Your Account {account} Balance is Insufficient.Your Given Amount is More{amount}";
            Console.WriteLine(msg1);
        }

        public void TestTransaction()
        {
            Account acc = new Account() { Id = 2, Type = "Business" , Balance = 145000.00 };
            acc.LowBalance += SendLowBalanceSms;
            acc.LowBalance += SendLowBalanceEmail;
            acc.Deposit(12400.00);
            acc.Withdraw(acc, 100000.00);
            acc.Withdraw(acc, 125000.00);
        }
    }

    class Deutsche
    {
        public void MakeLowBalanceCall(Account account,double amount)
        {
            string call = $"Your Account {account} Balance is Insufficient.Your Given Amount is More{amount}";
            Console.WriteLine(call);
        }

        public void TestTransaction()
        {
            Account acc = new Account() { Id = 3, Type = "Saving", Balance = 145000.00 };
            acc.LowBalance += MakeLowBalanceCall;
            acc.Withdraw(acc,142000.00);
            acc.Deposit(120000.00);
            acc.Withdraw(acc,150000.00);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hdfc hdfc = new Hdfc();
            hdfc.TestTransaction();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Citi citi = new Citi();
            citi.TestTransaction();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Deutsche deu = new Deutsche();
            deu.TestTransaction();
        }
    }
}