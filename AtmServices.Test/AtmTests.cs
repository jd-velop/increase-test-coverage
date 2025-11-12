namespace AtmServices.Test;

using AtmServices;

public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }


    [Fact]
    public void Test_Withdraw()

    {
        var withdrawSuccess = testAtm.withdraw(25);
        Assert.True(withdrawSuccess);
        Assert.Equal(75, testAtm.getBalance());

        var withdrawFails = testAtm.withdraw(150);
        Assert.False(withdrawFails);
        Assert.Equal(75, testAtm.getBalance());
    }

    [Fact]
    public void Test_Deposit()

    {
        var depositSuccess = testAtm.deposit(25);
        Assert.True(depositSuccess);
        Assert.Equal(125, testAtm.getBalance());

        var depositFails = testAtm.deposit(-25);
        Assert.False(depositFails);
        Assert.Equal(125, testAtm.getBalance());
    }

}

 
