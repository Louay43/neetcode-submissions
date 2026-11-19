
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] arr = ConvertToArray(s);
            string key = string.Join(",", arr);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }

            dict[key].Add(s);
        }

        return new List<List<string>>(dict.Values);
    }

    private int[] ConvertToArray(string s) {
        int[] arr = new int[26];

        foreach (char c in s) {
            arr[c - 'a']++;
        }

        return arr;
    }
}
