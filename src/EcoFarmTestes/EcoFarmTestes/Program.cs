using Xunit;

public class TestTests
{
	[Fact]
	public void SuccessfulTest() => Assert.Equal(1, 1);

	[Fact]
	public void FailureTest() => Assert.Equal(1, 2);
}