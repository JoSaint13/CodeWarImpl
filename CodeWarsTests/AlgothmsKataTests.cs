using System.Collections.Generic;
using System.Globalization;
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

        public void t( int number)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };

            //string respond = if (number <= 10) then dogs[0] elseif number <= 50 then dogs[1] elseif number = 101 then dogs[3] else dogs[2];

            var t = number <= 10 ? dogs[0] : number > 10 && number <= 50 ? dogs[1] : number > 50 && number < 101 ? dogs[2] : dogs[3];


            var dogs = new List<string>
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };

            return number <= 10 ? dogs[0] : number > 10 && number <= 50 ? dogs[1] : number > 50 && number < 101 ? dogs[2] : dogs[3];
            ;
        }
    }
}
