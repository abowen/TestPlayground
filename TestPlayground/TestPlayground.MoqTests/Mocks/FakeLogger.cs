using TestPlayground.Business.Interfaces;

namespace TestPlayground.MoqTests.Mocks
{
    public class FakeLogger : ILogger
    {
        public void LogError(string error)
        {
            LogErrorCalled = true;
        }

        internal bool LogErrorCalled { get; private set; }
    }
}
