/*
 * Helpful link which details the mocking framework
 * https://www.c-sharpcorner.com/article/moq-mocking-framework-with-xunit-net-testing-fr/

*/
using Moq;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace xUnitDemo.Test
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [Theory]
        [InlineData(5,3,2)]
        [InlineData(10,7,3)]
        [InlineData(10,9.5,.5)]
        public void Add_Test(int expected, int a, int b)
        {
            var actual = 0;
            actual = new Calculator().Add(a,b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subs_Test()
        {
            var oCalc = new Mock<ICalculator>();
            oCalc.Setup(c => c.Subs(3, 3)).Returns(0);
            Assert.Equal(0, oCalc.Object.Subs(3,3));
        }

        [Fact]
        public void Multiply_Test()
        {
            var oCalc = new Mock<ICalculator>();
            oCalc.Setup(c => c.Multiply(3, 3)).Returns(9);
            Assert.Equal(9, oCalc.Object.Multiply(3, 3));
        }
    }
}
