using Xunit;

namespace AlgorithmTest
{
    public class Test_ConvertJsVariableToCSharp
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = true;
            Assert.False(result, "1 should not be prime");
        }
        [Fact]
        public void AlwaysTrue()
        {
            Assert.True(true);
        }
        [Fact]
        public void AlwaysFalse()
        {
            Assert.True(false);
        }
        [Fact]
        public void ItDepends()
        {
            bool result = true;
            Assert.False(result, "Need Logic");
        }
    }
}
