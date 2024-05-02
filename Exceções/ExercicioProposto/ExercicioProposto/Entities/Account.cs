namespace ExercicioProposto.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public Account()
        {
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new Exceptions.DomainException("Not enough balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new Exceptions.DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
