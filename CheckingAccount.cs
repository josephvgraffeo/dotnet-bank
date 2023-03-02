public class CheckingAccount : BankAccount {

    public CheckingAccount (string newCustomerName, float newBalance) : base(newCustomerName, newBalance) {

        deposit(100f); // all checking accounts get $100 bonus in their account

    }

}