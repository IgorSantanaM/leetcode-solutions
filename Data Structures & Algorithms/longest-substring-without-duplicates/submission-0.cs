public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;
        int start = 0;

        Dictionary<char, int >charIndex = new();

        for(int end = 0; end < n; end++)
        {
            char currentChar = s[end];

            if(charIndex.ContainsKey(currentChar) && (int)charIndex[currentChar] >= start)
                start = (int)charIndex[currentChar] + 1;
            charIndex[currentChar] = end;

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
