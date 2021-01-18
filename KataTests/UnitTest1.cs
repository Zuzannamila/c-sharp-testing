using System;
using TypesIntro;
using Xunit;

namespace KataTests
{
    public class TestSetup
    {
        public Katas _testClass = new Katas();
    }
    public class ConvertToSassCaseTests : TestSetup
    {
        [Fact]
        public void GivenEmptyString_RetunsEmptyString()
        {
            // arrange
            // setup prior to invoking method under testing
            var input = "";

            // act
            // invoke a method
            var actual = _testClass.ConvertToSassCase(input);

            // assert
            // are our expectations correct

            Assert.Equal("", actual);
        }

        [Fact]
        public void GivenOneChar_RetunsCharUppercased()
        {
            // arrange
            var input = "e";

            // act
            var actual = _testClass.ConvertToSassCase(input);

            // assert
            Assert.Equal("E", actual);
        }
        [Fact]
        public void GiveMoreThanOneChar_ReturnUppercasedEveryother()
        {
            // arrange
            var input = "Hel";

            // act
            var actual = _testClass.ConvertToSassCase(input);

            //assert
            Assert.Equal("HeL", actual);

        }
    }
}
