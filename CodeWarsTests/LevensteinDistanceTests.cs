using System.Collections.Generic;
using CodeWars;
using Xunit;

namespace CodeWarTests
{
    public class LevensteinDistanceTests
    {
        [Fact]
        public void Find()
        {
            var words = new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" };

            var lev = new LevensteinDistance(words);

            Assert.Equal("strawberry", lev.FindMostSimilar("strawbery"));
            Assert.Equal("cherry", lev.FindMostSimilar("berry"));
        }
    }
}
