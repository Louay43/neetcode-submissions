
public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int left = 0;
        int max = 0;

        for (int right = 0; right < s.Length; right++) {
            char element = s[right];

            if (!count.ContainsKey(element))
                count[element] = 0;

            count[element] += 1;

            while (right - left + 1 - count.Values.Max() > k) {
                count[s[left]] -= 1;
                left++;
            }

            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}
