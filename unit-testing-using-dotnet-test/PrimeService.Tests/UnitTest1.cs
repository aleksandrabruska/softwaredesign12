namespace PrimeService.Tests;

using System.ComponentModel.DataAnnotations;
using PrimeService;

public class UnitTest1
{
   
    [Fact]
    public void CheckWithdraw()
    {
        var myAccount = new BankAccount();
        int currSaldo = myAccount.GetSaldo();
        myAccount.Withdraw(100);
        int newSaldo = myAccount.GetSaldo();
        Assert.Equal(100, currSaldo - newSaldo);
    }

    [Fact]
    public void CheckWithdrawLimit()
    {
        var myAccount = new BankAccount();
        int currSaldo = myAccount.GetSaldo();
        bool success = myAccount.Withdraw(currSaldo + 1000);
        Assert.Equal(false, success);

    }
    [Fact]
    public void CheckDeposit()
    {
        var myAccount = new BankAccount();
        int currSaldo = myAccount.GetSaldo();
        myAccount.Deposit(100);
        int newSaldo = myAccount.GetSaldo();
        Assert.Equal(100+currSaldo, newSaldo);
    }
}