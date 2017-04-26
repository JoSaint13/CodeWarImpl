using CodeWars;
using Xunit;

namespace CodeWarsTests
{
    public class ArrayKataTests
    {
        [Fact]
        public void TicTakToeIsSolved()
        {
            var board = new[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.Equal(1, ArrayKata.IsSolved(board));
        }
    }
}
