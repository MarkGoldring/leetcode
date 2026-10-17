public class Example
{
    public static char? FirstUnique(string input)
    {
        // guard aginst nulls and empty string
        if(string.IsNullOrEmpty(input))
        {
            return null;
        }

        // iterate once to determine counts
        var charCounts = new Dictionary<char, int>();
        foreach(var ch in input)
        {
            charCounts[ch] = charCounts.GetValueOrDefault(ch) + 1;
        }

        // second scan - find the first character that only occurs once
        foreach(var ch in input)
        {
            if(charCounts[ch] == 1)
            {
                return ch;
            }   
        }

        

        return null;
    }

    public class FirstUniqueTracker
    {
        private readonly Queue<char> _candidates = new();
        private readonly Dictionary<char, bool> _isRepeated = new();

        public void Add(char ch)
        {
            if(_isRepeated.TryAdd(ch, false))
            {
                // never seen so not repeated
                _candidates.Enqueue(ch);
                return;
            }

            // seen before
            _isRepeated[ch] = true;

            // purge queue head of repeated chars
            while(_candidates.Count > 0 && _isRepeated[_candidates.Peek()])
            {
                _candidates.Dequeue();
            }
        }

        public char? Current => _candidates.Count == 0 ? null : _candidates.Peek();
    }    
}
