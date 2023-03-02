BankAccount newAccount = new SavingsAccount("Carl", 736.98f);

Console.WriteLine(newAccount.customerName + "'s starting balance is $" + newAccount.getBalance());

newAccount.deposit(100f);

Console.WriteLine(newAccount.customerName + "'s current balance is $" + newAccount.getBalance());
