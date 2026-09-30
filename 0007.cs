public static class Solution0007 {
    public static int Reverse(int x) {
        try
        {
            var s = new String(Math.Abs(x).ToString().Reverse().ToArray()).TrimStart('0');
            return x < 0 ? -Int32.Parse(s) : Int32.Parse(s);
        }
        catch
        {
            return 0;
        }
    }
}
