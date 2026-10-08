using System.Text;

public static class Solution12 {
    public static string IntToRoman(int num) {
        var sb = new StringBuilder();
        
        // build a queue of digit values
        var q = new List<int>();
        if(num > 999) {
            q.Add((num / 1000) * 1000);
            num -= q[^1];
        }
        if(num > 99) {
            q.Add((num / 100) * 100);
            num -= q[^1];
        }
        if(num > 9) {
            q.Add((num / 10) * 10);
            num -= q[^1];
        }
        q.Add(num % 10);

        // process each digit
        foreach(var n in q) {
            sb.Append(Parse(n));
        }

        return sb.ToString();
    }

    private static string Parse(int num) {
        switch(num) {
            case 4:
                return "IV";
            case 9:
                return "IX";
            case 40:
                return "XL";
            case 90:
                return "XC";
            case 400:
                return "CD";
            case 900:
                return "CM";
            default:
                var sb = new StringBuilder();
                while(num > 0) {
                    if(num > 999)
                    {
                        sb.Append('M');
                        num -= 1000;
                    }
                    else if(num > 499)
                    {
                        sb.Append('D');
                        num -= 500;
                    }
                    else if(num > 99)
                    {
                        sb.Append('C');
                        num -= 100;
                    }
                    else if(num > 49)
                    {
                        sb.Append('L');
                        num -= 50;
                    }
                    else if(num > 9)
                    {
                        sb.Append('X');
                        num -= 10;
                    }
                    else if(num > 4)
                    {
                        sb.Append('V');
                        num -= 5;
                    }
                    else
                    {
                        sb.Append('I');
                        num -= 1;
                    }
                }
                return sb.ToString();
        }
    }
}
