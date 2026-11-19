public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(!counts.ContainsKey(num))
                counts[num] = 0;

            counts[num]++;
        }

        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        foreach(int num in counts.Keys) {
            int frequency = counts[num];

            if(!dict.ContainsKey(frequency))
                dict[frequency] = new List<int>();

            dict[frequency].Add(num);
        }

        List<int> frequencies = dict.Keys.ToList();
        frequencies.Sort((a, b) => b.CompareTo(a));

        List<int> res = new List<int>();

        foreach(int frequency in frequencies) {
            foreach(int num in dict[frequency]) {
                if(res.Count == k)
                    return res.ToArray();

                res.Add(num);
            }
        }

        return res.ToArray();
    }
}