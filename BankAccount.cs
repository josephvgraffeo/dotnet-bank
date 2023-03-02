public class BankAccount
{

    public string customerName = "";
    private float balance = 0;

    // default constructor
    public BankAccount()
    {

        customerName = "Bob";
        balance = 300;

    }

    public BankAccount(string newCustomerName, float newBalance)
    {

        customerName = newCustomerName;
        balance = newBalance;

    }

    public void deposit(float amount) {

        if (amount <= 0) {
            throw new Exception("Can not deposit a negative amount");
        }
        
        balance += amount;
    }

    public float getBalance() {
        return balance;
    }

}