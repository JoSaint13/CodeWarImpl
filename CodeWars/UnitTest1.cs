using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace CodeWars
{
    public class UnitTest1
    {
        [Fact]
        public void EaseTheStockBroker_tests()
        {
            Assert.Equal("Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;", EaseTheStockBroker.BalanceStatements("GOOG 300 542.0 B, AAPL 50 145.0 B, CSCO 250.0 29 B, GOOG 200 580.0 S"));
            //Assert.Equal("Buy: 263 Sell: 11802; Badly formed 2: CLH16.NYM 50 56 S ;OWW 1000 11 S ;", EaseTheStockBroker.BalanceStatements("ZNGA 1300 2.66 B, CLH15.NYM 50 56.32 B, OWW 1000 11.623 B, OGG 20 580.1 B"));           
        }

        [Fact]
        public void T1()
        {
            Assert.Equal("Buy: 0 Sell: 26041; Badly formed 1: ZNGA 1300 2.66 ;", EaseTheStockBroker.BalanceStatements("ZNGA 1300 2.66, CLH15.NYM 50 56.32 S, OWW 1000 11.623 S, OGG 20 580.1 S"));
        }
    }
}
