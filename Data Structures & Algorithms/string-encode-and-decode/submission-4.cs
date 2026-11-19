public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(string word in strs) {
            int length = word.Length;

            encoded += $"{length}#{word}";
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();

        for(int i = 0; i < s.Length; i++) {

            int separator = s.IndexOf('#', i);

            int length = int.Parse(s.Substring(i, separator - i));

            string word = s.Substring(separator + 1, length);
            res.Add(word);

            i = separator + length;
        }

        return res;
    }
}