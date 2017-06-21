using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest.Tests
{
    [CollectionDefinition("MemoryCalculator Collection")]
    public class TestCollection : ICollectionFixture<MemoryCalculatorFixture>
    {
    }
}
