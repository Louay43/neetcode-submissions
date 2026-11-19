
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int left = 0;
        Dictionary<char, int> count2 = new Dictionary<char, int>();
        Dictionary<char, int> count1 = new Dictionary<char, int>();

        foreach (char c in s1) {
            if (!count1.ContainsKey(c)) count1[c] = 0;
            count1[c]++;
        }

        // Populate count2 initially
        for (int i = 0; i < s1.Length; i++) {
            if (!count2.ContainsKey(s2[i])) count2[s2[i]] = 0;
            count2[s2[i]]++;
        }

        // Check initial window
        bool same = true;
        foreach (char key in count1.Keys) {
            if (!count2.ContainsKey(key) || count2[key] != count1[key]) {
                same = false;
                break;
            }
        }

        if (same) return true;

        // Slide the window
        for (int right = s1.Length; right < s2.Length; right++) {
            if (!count2.ContainsKey(s2[right]))
                count2[s2[right]] = 0;

            count2[s2[right]]++;

            count2[s2[left]]--;
            left++;

            same = true;
            foreach (char key in count1.Keys) {
                if (!count2.ContainsKey(key) || count2[key] != count1[key]) {
                    same = false;
                    break;
                }
            }

            if (same) return true;
        }

        return false;
    }
}
