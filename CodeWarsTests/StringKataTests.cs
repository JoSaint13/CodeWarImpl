using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CodeWars;
using Xunit;
using Xunit.Abstractions;

namespace CodeWarsTests
{
    public class StringKataTests
    {
        private readonly ITestOutputHelper _output;

        public StringKataTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldReturnFirstNonRepeatedLetter()
        {
            Assert.Equal("a", StringKata.FirstNonRepeatingLetter("a"));
            Assert.Equal("t", StringKata.FirstNonRepeatingLetter("stress"));
            Assert.Equal("e", StringKata.FirstNonRepeatingLetter("moonmen"));
        }

        [Fact]
        public void ShoulShiftVowel()
        {
            Assert.Equal("This is a test!", StringKata.VowelShifting("This is a test!", 0));         
            Assert.Equal("Thes is i tast!", StringKata.VowelShifting("This is a test!", 1));
            Assert.Equal("This as e tist!", StringKata.VowelShifting("This is a test!", 3));
            Assert.Equal("This is a test!", StringKata.VowelShifting("This is a test!", 4));
            Assert.Equal("This as e tist!", StringKata.VowelShifting("This is a test!", -1));
            Assert.Equal("This as e tist!", StringKata.VowelShifting("This is a test!", -5));
            Assert.Equal("aTkbh DQjkWzFi mLggOuT JO.", StringKata.VowelShifting("OTkbh DQjkWzFa mLggiOT Ju.", -46));
        }

        [Fact]
        public void ShoulShiftVowel2()
        {
            Assert.Equal("QCTxobgv WvzhS i mORu.", StringKata.VowelShifting2("QCTxibgv WvzhS u mORo.", -4));
            Assert.Equal("aTkbh DQjkWzFi mLggOuT JO.", StringKata.VowelShifting2("OTkbh DQjkWzFa mLggiOT Ju.", -46));
        }

        [Fact]
        public void ShoulShiftVowel3()
        {
            Assert.Equal("QCTxobgv WvzhS i mORu.", StringKata.VowelShifting3("QCTxibgv WvzhS u mORo.", -4));
            Assert.Equal("aTkbh DQjkWzFi mLggOuT JO.", StringKata.VowelShifting3("OTkbh DQjkWzFa mLggiOT Ju.", -46));
        }

        public static string sumStrings(string a, string b)
        {

           var list = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
            list.Add(1);

            new List<int>(list.Take(list.Count-1).AsEnumerable());
            list.AsEnumerable();
           
            

            list.Add(1);


            var lsit2 = new List<int>(  );
            
            var ba = BigInteger.Parse(string.IsNullOrEmpty(a) ? "0" : a);
            var bb = BigInteger.Parse(string.IsNullOrEmpty(b) ? "0" : b);
            return (ba + bb).ToString();
        }
    }
}
