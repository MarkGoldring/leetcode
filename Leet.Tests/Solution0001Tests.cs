public static class Solution0001Tests
{
    [Theory]
    [InlineData(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
    [InlineData(new[] {3, 2, 4}, 6, new[] {1, 2})]
    [InlineData(new[] {3, 3}, 6, new[] {0, 1})]
    public static void TwoSum_ShouldReturnExpectedResult(int[] nums, int target, int[] expected)
    {
        var result = Solution.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}