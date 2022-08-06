namespace AzureDevOpsGettingStarted.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Green()
        {
            Assert.True(true, "Always green unit test.");
        }

        [Fact]
        public void Red()
        {
            Assert.True(false, "Always red unit test.");
        }
    }
}