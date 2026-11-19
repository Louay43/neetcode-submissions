
public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";

        Dictionary<char, int> count1 = new Dictionary<char, int>();
        Dictionary<char, int> count2 = new Dictionary<char, int>();

        foreach (char c in t) {
            if (!count2.ContainsKey(c)) count2[c] = 0;
            count2[c]++;
        }

        int left = 0;
        int formed = 0;
        int required = count2.Count;
        int minLength = int.MaxValue;
        int minStart = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            if (!count1.ContainsKey(c)) count1[c] = 0;
            count1[c]++;

            if (count2.ContainsKey(c) &&
                count1[c] == count2[c]) {
                formed++;
            }

            while (formed == required) {
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minStart = left;
                }

                char removed = s[left];
                count1[removed]--;

                if (count2.ContainsKey(removed) &&
                    count1[removed] < count2[removed]) {
                    formed--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue
            ? ""
            : s.Substring(minStart, minLength);
    }
}
