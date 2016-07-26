﻿using CodeWars;
using Xunit;

namespace BracesTests
{

    public class ValidationTests
    {
        [Fact]      
        public void ShouldValidate()
        {
            Assert.True(BracesClass.Braces("(){}[]"));
            Assert.False(BracesClass.Braces("(}"));
            Assert.False(BracesClass.Braces("[(])"));
            Assert.True(BracesClass.Braces("([{}])"));
        }
    }
}
