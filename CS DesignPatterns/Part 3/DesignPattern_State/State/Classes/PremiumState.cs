namespace State.Classes
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Premium indicates an interest bearing state
    /// </remarks>
    /// </summary>
    class PremiumState : State
    {
        // Overloaded constructors
        public PremiumState(State state)
          : this(state.Balance, state.Account)
        {
        }

        public PremiumState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new OverdrawnState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new StandardState(this);
            }
        }
    }
}
