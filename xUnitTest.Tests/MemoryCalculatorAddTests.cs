using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest.Tests
{
    [Collection("MemoryCalculator Collection")]
    public class MemoryCalculatorAddTests
    {
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorAddTests(MemoryCalculatorFixture fixture)
        {
            _fixture = fixture;
            _fixture.sut.Clear();

        }

        [Fact]
        public void ShouldAddPositiveNumbers()
        {
            _fixture.sut.Add(10, 5);

            Assert.Equal(15, _fixture.sut.Currentvalue);
        }


        [Fact]
        public void ShouldAddNegativeNumbers()
        {
            _fixture.sut.Add(-7, -3);

            Assert.Equal(-10, _fixture.sut.Currentvalue);
        }

    }
}
