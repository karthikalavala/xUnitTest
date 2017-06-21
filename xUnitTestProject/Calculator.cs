using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace xUnitTestProject
{
    public class Calculator
    {
        public int Currentvalue { get; private set; }
        public Calculator()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        public void Add(int a, int b)
        {
            Currentvalue = a + b;
        }

        public void Subtract(int a, int b)
        {
            Currentvalue = a - b;
        }

        public void Clear()
        {
            Currentvalue = 0;
        }

    }
}
