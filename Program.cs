
// run example
IList<IList<string>> knowledge = [["name", "bob"], ["age", "two"]];
var result = Solution1807.Evaluate("(name)is(age)yearsold", knowledge);

Console.WriteLine(result);
