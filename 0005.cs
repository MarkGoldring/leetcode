public static class Solution0005 {
    public static string LongestPalindrome(string s) {

        var start = 0;
        var end = 0;
        for(var i = 0; i <= s.Length; i++) {
            var odd = Expand(s, i, i);
            var even = Expand(s, i, i+1);
            if(even.r - even.l > end - start) {
                start = even.l;
                end = even.r;
            }
            else if(odd.r - odd.l > end - start) {
                start = odd.l;
                end = odd.r;
            }
        }

        return s[start..end];
    }   

    private static (int l, int r) Expand(string s, int left, int right) {
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            left -= 1;
            right += 1;       
        }
        return (left + 1, right);
    }     
}
