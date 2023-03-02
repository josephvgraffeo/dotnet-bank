public class SavingsAccount : BankAccount {

    public SavingsAccount (string newCustomerName, float newBalance) : base(newCustomerName, newBalance) {

        deposit(200f); // all savings accounts get $200 bonus in their account

    }

}