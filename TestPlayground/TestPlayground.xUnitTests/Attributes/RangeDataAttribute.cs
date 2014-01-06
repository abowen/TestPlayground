using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit.Extensions;

namespace TestPlayground.xUnitTests.Attributes
{
    public class RangeDataAttribute : DataAttribute
    {
        private readonly int _count;
        private readonly int _start;

        public RangeDataAttribute(int start, int count)
        {
            _start = start;
            _count = count;
        }

        public override IEnumerable<object[]> GetData(MethodInfo methodUnderTest, Type[] parameterTypes)
        {
            return Enumerable.Range(_start, _count)
                .Select(i => new object[] {i});
        }
    }
}
