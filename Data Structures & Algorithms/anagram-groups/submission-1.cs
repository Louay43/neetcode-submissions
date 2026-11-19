
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach (string s in strs) {
            int[] count = new int[26];

            foreach (char c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!dict.TryGetValue(key, out List<string> group)) {
                group = new List<string>();
                dict[key] = group;
            }

            group.Add(s);
        }

        return dict.Values.ToList();
    }
}
