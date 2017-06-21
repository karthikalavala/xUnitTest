using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestProject;

namespace xUnitTest.Tests
{
    public class DDT_Theory
    {
        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(1, 7, 8)]
        [InlineData(1, 6, 7)]
        public void ShouldAdd(int first, int second, int expected)
        {
            var sut = new Calculator();
            sut.Add(first, second);
            Assert.Equal(expected, sut.Currentvalue);
        }
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 5, 10, -5 };
                yield return new object[] { 1, 7, 8 };
            }
        }

        [Theory]
        [MemberData("TestData")]
        public void ShouldAdd2(int first, int second, int expected)
        {
            var sut = new Calculator();
            sut.Add(first, second);
            Assert.Equal(expected, sut.Currentvalue);
        }

        [Fact]
        public void ShouldAdd3(int first, int second, int expected)
        {
            var sut = new Calculator();
            sut.Add(first, second);
            Assert.Equal(expected, sut.Currentvalue);
        }
    }
}
