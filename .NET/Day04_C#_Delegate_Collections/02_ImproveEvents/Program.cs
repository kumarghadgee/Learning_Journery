namespace _02_ImprovedEvents
{
    delegate void BalanceHandler(Account account,BalanceEventArgs e);
    class BalanceEventArgs : EventArgs
    {
        public double TxAmount { get; set; }

        public DateTime TxTime{ get; set; }
    }

    class Account
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public double Balance { get; set; }

        private event BalanceHandler _lowBalance = null;
        public event BalanceHandler LowBalance
        {
            add { _lowBalance += value; }
            remove { _lowBalance -= value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Your Deposited Amount is {amount}");

        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                BalanceEventArgs e = new BalanceEventArgs
                {
                    TxAmount = amount,
                    TxTime = DateTime.Now
                };
                _lowBalance(this, e);
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Your Withdrawn Amount is {amount}");
            }
        }

    }

    class HDFC
    {
        public void SendLowBalanceSms(Account account,BalanceEventArgs e)
        {
            string msg = $"Account Id is {account.Id} where the transcation is done on {e.TxTime} with and insufficient balance{e.TxAmount}";
            Console.WriteLine(msg);
        }

        public void TestTransaction()
        {
            Account acc = new Account() { Id = 1, Type = "Saving", Balance = 1000000.00 };
            acc.LowBalance += SendLowBalanceSms;
            acc.Withdraw(120000.00);
            acc.Deposit(123456.00);
            acc.Withdraw(123456789.00);

        }
    }

    class Citi
    {
        public void SendLowBalanceSms(Account account,BalanceEventArgs e)
        {
            string msg = $"Account Id ia {account.Id} transaction done on {e.TxTime} which is more {e.TxAmount}";
            Console.WriteLine(msg);
        }

        public void SendLowBalanceEmail(Account account,BalanceEventArgs e)
        {
            string msg = $"Account Id ia {account.Id} transaction done on {e.TxTime} which is more {e.TxAmount}";
            Console.WriteLine(msg);
        }
        public void TestTransaction()
        {
            Account acc = new Account() { Id = 2, Type = "Saving", Balance = 1022500.00 };
            acc.LowBalance += SendLowBalanceSms;
            acc.LowBalance += SendLowBalanceEmail;
            acc.Withdraw(100000.00);
            acc.Deposit(123456.00);
            acc.Withdraw(123456789.00);
        }
    }
    
    class Deutsche
    {
        public void MakeLowBalanceCall(Account account,BalanceEventArgs e)
        {
            string msg = $"Account Id ia {account.Id} transaction done on {e.TxTime} which is more {e.TxAmount}";
            Console.WriteLine(msg);
        }

        public void TestTransaction()
        {
            Account acc = new Account() { Id = 3, Type = "Saving", Balance = 1332500.00 };
            acc.LowBalance += MakeLowBalanceCall;
            acc.Withdraw(12345.00);
            acc.Deposit(1234000.00);
            acc.Withdraw(123456789.00);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HDFC hdfc = new HDFC();
            hdfc.TestTransaction();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Citi citi = new Citi();
            citi.TestTransaction();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Deutsche deu = new Deutsche();
            deu.TestTransaction();
        }
    }
}