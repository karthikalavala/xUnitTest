using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using xUnitTestProject;

namespace xUnitTest.Tests
{
    public class MemoryCalculatorFixture
    {
        public Calculator sut { get; private set; }

        public MemoryCalculatorFixture()
        {
            sut = new Calculator();
        }
    }
    public class CalculatorTests : IClassFixture<MemoryCalculatorFixture>
    {
        private readonly ITestOutputHelper _testOuput;
        private readonly MemoryCalculatorFixture _fixture;

        public CalculatorTests (ITestOutputHelper helper, MemoryCalculatorFixture fixture)
        {
            _testOuput = helper;
            _fixture = fixture;
        }

        [Fact]
        [Trait("Calculation", "Arthimetic")]
        public void ShouldAdd()
        {
            _fixture.sut.Add(10, 2);
                

            Assert.Equal(12, _fixture.sut.Currentvalue);
        }

        [Fact]
        [Trait("Calculation", "Arthimetic")]
        public void ShouldSubstract()
        {
            _fixture.sut.Subtract(10, 2);

            Assert.Equal(8, _fixture.sut.Currentvalue);
        }
    }
}
