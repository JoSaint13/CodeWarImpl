using CodeWars;
using Xunit;

namespace CodeWarTests
{
    
    public class StringMixTest
    {
        [Fact]
        public void MixTest()
        {
        //    var actual1 = StringsMix.Mix("Are they here", "yes, they are here");
        //    Assert.Equal("2:eeeee/2:yy/=:hh/=:rr", actual1);

        //    //var actual2 = StringsMix.Mix("Lords of the Fallen", "gamekult");
        //    //Assert.Equal("1:ee/1:ll/1:oo", actual2);

        //    var actual3 = StringsMix.Mix("Are they here", "yes, they are here");
        //    Assert.Equal("2:eeeee/2:yy/=:hh/=:rr", actual3);

            var actual4 = StringsMix.Mix("looping is fun but dangerous", "less dangerous than coding");
            Assert.Equal("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg", actual4);


            var actual5 = StringsMix.Mix(" In many languages", " there's a pair of functions");
            Assert.Equal("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt", actual5);

            Assert.Equal("", StringsMix.Mix("codewars", "codewars"));
            Assert.Equal("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr", StringsMix.Mix("A generation must confront the looming ", "codewarrs"));
        }

    }

  
}
