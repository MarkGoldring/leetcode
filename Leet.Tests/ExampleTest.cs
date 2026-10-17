public static class ExampleTests
{
    [Fact]
    public static void FirstUnique_ReturnsNullWhenNullInput()
    {
        var result = Example.FirstUnique(null!);
        Assert.Null(result);
    }

    [Fact]
    public static void FirstUnique_ReturnsNullWhenEmptyInput()
    {
        var result = Example.FirstUnique(string.Empty);
        Assert.Null(result);
    }

    [Fact]
    public static void FirstUnique_ReturnsFirstUnique()
    {
        var result = Example.FirstUnique("abcde");
        Assert.Equal('a', result);
    }

    [Fact]
    public static void FirstUnique_ReturnsNullIfNoUnique()
    {
        var result = Example.FirstUnique("aabb");
        Assert.Null(result);
    }
}