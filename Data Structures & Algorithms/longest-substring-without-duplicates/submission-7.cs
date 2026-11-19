public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        HashSet<char> set = new HashSet<char>();
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char element = s[right];

            while (set.Contains(element)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(element);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}