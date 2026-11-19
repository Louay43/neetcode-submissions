
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (!dict.ContainsKey(num)) dict[num] = -1;
        }

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (dict[num] == -1) dict[num] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (dict.ContainsKey(complement) && dict[complement] != i) {
                int lowerIndex = Math.Min(i, dict[complement]);
                int higherIndex = Math.Max(i, dict[complement]);

                return new int[] {
                    lowerIndex,
                    higherIndex
                };
            }
        }

        return null;
    }
}
