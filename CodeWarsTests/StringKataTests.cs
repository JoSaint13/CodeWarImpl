using CodeWars;
using Xunit;

namespace CodeWarTests
{
    public class StringKataTests
    {
        [Fact]
        public void ShouldReturnFirstNonRepeatedLetter()
        {
            Assert.Equal("a", StringKata.FirstNonRepeatingLetter("a"));
            Assert.Equal("t", StringKata.FirstNonRepeatingLetter("stress"));
            Assert.Equal("e", StringKata.FirstNonRepeatingLetter("moonmen"));
        }
    }
}
