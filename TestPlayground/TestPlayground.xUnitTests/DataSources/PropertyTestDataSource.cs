using System.Collections.Generic;

namespace TestPlayground.xUnitTests.DataSources
{
    public static class PropertyTestDataSource
    {
        // Could read this from text file / database
        private static readonly List<object[]> Data = new List<object[]>
        {
            new object[]  { int.MinValue, false },
            new object[]  { -1, false },
            new object[]  { 0, false },
            new object[]  { 1, true },
            new object[]  { int.MaxValue, true},
        };

        public static IEnumerable<object[]> TestData
        {
            get { return Data; }
        }
    }
}
