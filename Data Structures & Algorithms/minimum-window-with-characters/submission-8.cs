
public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";

        int[] count = new int[128];

        foreach (char c in t) {
            count[c]++;
        }

        int left = 0;
        int remaining = t.Length;
        int minLength = int.MaxValue;
        int minStart = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            if (count[c] > 0) {
                remaining--;
            }

            count[c]--;

            while (remaining == 0) {
                int length = right - left + 1;

                if (length < minLength) {
                    minLength = length;
                    minStart = left;
                }

                char removed = s[left];
                count[removed]++;

                if (count[removed] > 0) {
                    remaining++;
                }

                left++;
            }
        }

        return minLength == int.MaxValue
            ? ""
            : s.Substring(minStart, minLength);
    }
}
