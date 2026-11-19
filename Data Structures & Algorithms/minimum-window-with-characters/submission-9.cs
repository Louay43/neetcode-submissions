
public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";

        Dictionary<char, int> count2 = new Dictionary<char, int>();
        Dictionary<char, int> count1 = new Dictionary<char, int>();

        int left = 0;
        int minLength = s.Length + 1;
        int minStart = 0;

        foreach (char c in t) {
            if (!count2.ContainsKey(c)) count2[c] = 0;
            count2[c]++;
        }

        foreach (char c in s) {
            if (!count1.ContainsKey(c)) count1[c] = 0;
            count1[c]++;
        }

        // Substring does not even exist
        if (!DictionaryContains(count1, count2)) {
            return "";
        }

        foreach (char c in count1.Keys)
            count1[c] = 0;

        for (int i = 0; i < t.Length; i++) {
            count1[s[i]]++;
        }

        if (DictionaryContains(count1, count2)) {
            return s.Substring(0, t.Length);
        }

        for (int right = t.Length; right < s.Length; right++) {
            count1[s[right]]++;

            while (DictionaryContains(count1, count2)) {
                // Save the current valid window
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minStart = left;
                }

                count1[s[left]]--;
                left++;
            }
        }

        return minLength == s.Length + 1
            ? ""
            : s.Substring(minStart, minLength);
    }

    public bool DictionaryContains(
        Dictionary<char, int> count1,
        Dictionary<char, int> count2
    ) {
        foreach (char key in count2.Keys) {
            if (!count1.ContainsKey(key) || count1[key] < count2[key]) {
                return false;
            }
        }

        return true;
    }
}
