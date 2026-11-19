
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> occurencesOfCharactersS = CreateDic(s);
        Dictionary<char, int> occurencesOfCharactersT = CreateDic(t);

        if (occurencesOfCharactersS.Keys.Count != occurencesOfCharactersT.Keys.Count)
            return false;

        foreach (char c in occurencesOfCharactersS.Keys) {
            if (occurencesOfCharactersT.ContainsKey(c)) {
                if (occurencesOfCharactersT[c] == occurencesOfCharactersS[c]) {
                    continue;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        return true;
    }

    private Dictionary<char, int> CreateDic(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!dict.ContainsKey(c)) dict[c] = 0;
            dict[c]++;
        }

        return dict;
    }
}
