using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPaymentsConsoleApp.Tests
{
    public class BankAccountTests
    {
        //[Fact]

        //[Theory]
        //[InlineData(0)]
        void NazwaMEtodyTestowaniej_Scenariusz_CoOczekujemy()
        {
            //Arrange (przygotowanie)

            //Act (wykonanie)

            //Assert (sprawdzenie)
        }



















        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(2001)]
        [InlineData(159878)]
        public void BankAccount_PositiveInitialBalnce_SetBalane(decimal initialBalance)
        {
            //Arrange (przygotowanie)
            BankAccount bankAccount;

            //Act (wykonanie)
            bankAccount = new BankAccount(initialBalance);


            //Assert (sprawdzenie)
            Assert.Equal(initialBalance, bankAccount.Balance);
        }

        [Theory]
        [InlineData(-15)]
        [InlineData(-1)]
        [InlineData(-2001)]
        [InlineData(-159878)]
        public void BankAccount_NegativeInitialBalnce_ThrowArgumentOutOfRangeException(decimal initialBalance)
        {
            //Arrange (przygotowanie)
            Action action;

            //Act (wykonanie)

            action = ()=> new BankAccount(initialBalance);

            //Assert (sprawdzenie)
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

    }
}
