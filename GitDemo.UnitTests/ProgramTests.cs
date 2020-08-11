using Xunit;

namespace GitDemo.UnitTests
{
    public sealed class ProgramTests
    {
        [Fact]
        public void Test1()
        {
            Program.Main(new[] { "arg0", "arg1" });
        }
    }
}
