using CodeWars;
using Xunit;

namespace CodeWarTests
{
    public class CountTheMonkeyMonkeyTests
    {
        [Fact]
        public void MonkeyCount()
        {
            Assert.Equal(new[] { 1, 2, 3 }, CountTheMonkeys.MonkeyCount(3));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, CountTheMonkeys.MonkeyCount(9));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, CountTheMonkeys.MonkeyCount(10));
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, CountTheMonkeys.MonkeyCount(5));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, CountTheMonkeys.MonkeyCount(20));
        }

        [Fact]
        public void MonkeyCount2()
        {
            Assert.Equal(new[] { 1, 2, 3 }, CountTheMonkeys.MonkeyCount2(3));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, CountTheMonkeys.MonkeyCount2(9));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, CountTheMonkeys.MonkeyCount2(10));
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, CountTheMonkeys.MonkeyCount2(5));
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, CountTheMonkeys.MonkeyCount2(20));
        }
    }
}
