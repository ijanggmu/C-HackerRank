using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRankTest
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(3,2,5)]
        [InlineData(3,2,6)]
        [InlineData(double.MaxValue,5,double.MaxValue)]
        [InlineData(double.MaxValue,5,double.MinValue)]
        [InlineData(double.MinValue,5,double.MinValue)]
        public void Add_SimpleValuesShouldAdded(double x, double y, double expected)
        {
            var actual=Calculator.adds(x, y);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivideByZero()
        {
            double expected = 0;
            var actual = Calculator.div(5, 0);

            Assert.Equal(expected, actual);
        }
    }
}
