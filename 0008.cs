public static class Solution0008 {
    public static int MyAtoi(string s) {
        List<char> whitespace = [' ', '\t', '\r', '\n'];
        List<char> digits = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        long sum = 0;
        var started = false;
        var isNegative = false;
        foreach(var ch in s) {
            // handle whitespace
            if(whitespace.Contains(ch)) {
                if(started) {
                    break; // non-digit
                }
            } else if(ch == '-' && !started) {
                isNegative = true;
                started = true;
            } else if(ch == '+' && !started) {
                started = true;
            } else if(digits.Contains(ch)) {
                // this digit is now the unit - so multiple existing value by 10
                sum *= 10;
                sum += ch - '0';
                started = true;
                // bounds checking
                if(isNegative && -sum <= int.MinValue) {
                    return int.MinValue;
                } else if (!isNegative && sum >= int.MaxValue){
                    return int.MaxValue;
                }
            } else {
                break; // non-digit
            }
        }

        // cast to int32 and sign accordingly
        return isNegative 
            ? -Convert.ToInt32(sum)
            : Convert.ToInt32(sum);
    }
}
