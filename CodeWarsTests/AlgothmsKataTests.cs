using CodeWars;
using Xunit;

namespace CodeWarsTests
{
    public class AlgothmsKataTests
    {
        [Fact]
        public void SimplePigLatin()
        {
            Assert.Equal("igPay atinlay siay oolcay", AlgorithmsKata.PigIt("Pig latin is cool"));
            Assert.Equal("hisTay siay ymay tringsay", AlgorithmsKata.PigIt("This is my string"));
        }

        [Fact]
        public void SimplePigLatin2()
        {
            Assert.Equal("igPay atinlay siay oolcay", AlgorithmsKata.PigIt2("Pig latin is cool"));
            Assert.Equal("hisTay siay ymay tringsay", AlgorithmsKata.PigIt2("This is my string"));
        }
    }
}
