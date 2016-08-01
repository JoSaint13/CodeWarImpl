using System;
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

            _output.WriteLine("Thes is i tast!");
            var actual1 = StringKata.VowelShifting("This is a test!", 1);
            _output.WriteLine(actual1);
            Assert.Equal("Thes is i tast!", actual1);
            Assert.Equal("This as e tist!", StringKata.VowelShifting("This is a test!", 3));
        }
    }
}
