namespace PrimeService;

public class BankAccount
{
    private int saldo;
    public BankAccount()
    {
        this.saldo = 1000;
    }
    public bool Withdraw(int amount)
    {
        if (amount > saldo)
            return false;
        this.saldo -= amount;
        return true;
       
    }
    public int GetSaldo()
    {
        return this.saldo;
    }

    public void Deposit(int amount)
    {
        this.saldo = amount + this.saldo;
    }
}
