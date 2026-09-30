public class Solution1807Tests
{
    [Fact]
    public void Evaluate_SubstitutesMultipleKnownKeys()
    {
        IList<IList<string>> knowledge = [["name", "bob"], ["age", "two"]];

        var actual = Solution1807.Evaluate("(name)is(age)yearsold", knowledge);

        Assert.Equal("bobistwoyearsold", actual);
    }

    [Fact]
    public void Evaluate_UnknownKeyBecomesQuestionMark()
    {
        IList<IList<string>> knowledge = [["a", "b"]];

        var actual = Solution1807.Evaluate("hi(name)", knowledge);

        Assert.Equal("hi?", actual);
    }

    [Fact]
    public void Evaluate_RepeatedKeyIsSubstitutedEachTime()
    {
        IList<IList<string>> knowledge = [["a", "yes"]];

        var actual = Solution1807.Evaluate("(a)(a)(a)aaa", knowledge);

        Assert.Equal("yesyesyesaaa", actual);
    }
}
