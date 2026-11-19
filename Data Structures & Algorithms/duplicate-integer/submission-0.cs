public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> occurences = new Dictionary<int,int>();

        foreach(int num in nums) {
            if(!occurences.ContainsKey(num)) occurences[num] = 0;
            occurences[num]++;
        }

        foreach(int key in occurences.Keys) {
            if(occurences[key] > 1) return true;
        }
        return false;
    }
}