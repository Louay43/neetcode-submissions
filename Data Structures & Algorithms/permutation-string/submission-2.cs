
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int left = 0;
        Dictionary<char, int> count2 = new Dictionary<char, int>();
        Dictionary<char, int> count1 = new Dictionary<char, int>();

        foreach (char c in s1) {
            if (!count1.ContainsKey(c)) count1[c] = 0;
            count1[c]++;
        }

        for (int right = s1.Length - 1; right < s2.Length; right++) {
            //check if this window works
            count2.Clear();

            //populate it
            for (int i = left; i <= right; i++) {
                if (!count2.ContainsKey(s2[i])) count2[s2[i]] = 0;
                count2[s2[i]]++;
            }

            bool same = true;
            foreach (char key in count1.Keys) {
                if (!count2.ContainsKey(key) || count2[key] != count1[key]) {
                    same = false;
                    break;
                }
            }

            if (same) {
                return true;
            }
            else {
                left++;
            }
        }

        return false;
    }
}
