public static class Solution0009 {
    public static bool IsPalindrome(int x) {
        // all negatives values are not as per examples
        if(x < 0) {
            return false;
        }   
        // values 0-9 count 
        if (x < 10) {
            return true;
        }
        // convert to string
        var s = x.ToString();
        // get sides
        var l = s.Length;
        var lhs = s[..(l / 2)];
        var rhs = (l % 2 == 0) 
            ? s[(l / 2) ..]
            : s[(l / 2 + 1) ..];
        // does left half equal right half?
        return lhs == new string([.. rhs.Reverse()]); 
    }
}
