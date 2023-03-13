Account account = new Account();

account.Name = "Main";
account.Account_number = 1;
account.Amount = 100;


class Account
{
    private string name;
    private int account_number;
    private double amount;

    public string Name { get => name; set => name = value; }
    public int Account_number { get => account_number; set => account_number = value; }
    public double Amount { get => amount; set => amount = value; }
}