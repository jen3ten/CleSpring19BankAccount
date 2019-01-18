using System;
using Xunit;

namespace BankAccount.Tests
{
    public class CheckingAccountTests
    {
        [Fact]
        public void Balance_Starts_At_Zero()
        {
            // Arrange
            CheckingAccount account = new CheckingAccount();

            // Act

            // Assert
            Assert.Equal(0M, account.Balance);
        }

        [Fact]
        public void Deposit_Increases_Balance()
        {
            CheckingAccount account = new CheckingAccount();

            account.Deposit(200M);

            Assert.Equal(200M, account.Balance);
        }

        [Fact]
        public void Withdrawal_Decreases_Balance()
        {
            CheckingAccount account = new CheckingAccount();
            account.Deposit(100M);

            account.Withdrawal(100M);

            Assert.Equal(0M, account.Balance);
        }
    }
}
