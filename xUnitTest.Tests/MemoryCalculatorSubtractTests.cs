using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest.Tests
{
    [Collection("MemoryCalculator Collection")]
    public class MemoryCalculatorSubtractTests
    {
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorSubtractTests(MemoryCalculatorFixture fixture)
        {
            _fixture = fixture;
            _fixture.sut.Clear();

        }

        [Fact]
        public void ShouldSubtractPositiveNumbers()
        {
            _fixture.sut.Subtract(10, 5);

            Assert.Equal(5, _fixture.sut.Currentvalue);
        }

        [Fact]
        public void ShouldSubtractNegativeNumbers()
        {
            _fixture.sut.Subtract(-10, -5);

            Assert.Equal(-5, _fixture.sut.Currentvalue);
        }
    }
}
