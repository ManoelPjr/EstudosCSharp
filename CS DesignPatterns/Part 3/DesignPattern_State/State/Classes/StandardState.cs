namespace State.Classes
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Standard indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class StandardState : State
    {
        // Overloaded constructors

        public StandardState(State state) :
          this(state.Balance, state.Account)
        {
        }

        public StandardState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
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
            if (balance < lowerLimit)
            {
                account.State = new OverdrawnState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new PremiumState(this);
            }
        }
    }
}
