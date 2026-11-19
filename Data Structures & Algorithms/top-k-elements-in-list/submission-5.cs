public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(!count.ContainsKey(num))
                count[num] = 0;

            count[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(int num in count.Keys) {
            int frequency = count[num];

            if(buckets[frequency] == null)
                buckets[frequency] = new List<int>();

            buckets[frequency].Add(num);
        }

        List<int> res = new List<int>();

        for(int i = buckets.Length - 1; i >= 0; i--) {
            if(buckets[i] == null)
                continue;

            foreach(int num in buckets[i]) {
                res.Add(num);

                if(res.Count == k)
                    return res.ToArray();
            }
        }

        return res.ToArray();
    }
}