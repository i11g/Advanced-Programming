using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{   
       
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        //Arrange
        double initialBalance = 50;
               
        //Act
        BankAccount result=new BankAccount(initialBalance);

        //Assert

        Assert.That(50, Is.EqualTo(result.Balance));
        
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        //Arrange
        double initialBalance = 50;
        double deposit = 30;
        
        //Act

        BankAccount start=new BankAccount(initialBalance);
        start.Deposit(deposit);
        
        //Assert
        Assert.That(80, Is.EqualTo(start.Balance));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        double initialBalance = 50;
        double deposit = -30;
        BankAccount start = new BankAccount(initialBalance);

        //Act&Assert
        Assert.That(()=>start.Deposit(deposit), Throws.ArgumentException);
        
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        //Arrange
        double initialBalance = 50;
        double deposit = 30;

        //Act
        BankAccount start = new BankAccount(initialBalance);
        start.Withdraw(deposit);

        //Assert
        Assert.That(20, Is.EqualTo(start.Balance));

    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        double initialBalance = 50;
        double deposit = -30;
        BankAccount start = new BankAccount(initialBalance);

        //Act&Assert
        Assert.That(() => start.Withdraw(deposit), Throws.ArgumentException);

    }
    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        //Arrange
        double initialBalance = 50;
        double deposit = 70;
        BankAccount start = new BankAccount(initialBalance);

        //Act&Assert
        Assert.That(() => start.Withdraw(deposit), Throws.ArgumentException);
    }
}
