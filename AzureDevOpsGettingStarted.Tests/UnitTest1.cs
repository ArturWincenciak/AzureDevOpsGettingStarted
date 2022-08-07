namespace AzureDevOpsGettingStarted.Tests;

public class UnitTest1
{
    [Fact]
    public void Green()
    {
        Assert.True(true, "Always green unit test.");
    }

    [Fact(Skip = "Skip always red unit test.")]
    public void Red()
    {
        Assert.True(false, "Always red unit test.");
    }
}