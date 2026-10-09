public class Solution14Tests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_ReturnsExpectedValue(string[] strs, string prefix)
    {
        var actual = Solution0014.LongestCommonPrefix(strs);
        Assert.Equal(prefix, actual);
    }
}
