public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        int all = 1;

        int countZero = 0;
        int zeroIndex = -1;

        //get how manyu zeros and the index
        for(int i = 0 ; i < nums.Length; i++) {
            int num = nums[i];
            if(num == 0) {
                countZero++;
                zeroIndex = i;
            }
        }

        //if more than one zero then gg
        if(countZero > 1) return output;

        //get the total
        foreach(int num in nums) if(num != 0) all *= num;

        //if just one zero then put the all in its position
        if(countZero == 1) {
            output[zeroIndex] = all;
            return output;
        }

        //just divide
        for(int i = 0 ; i < nums.Length; i++) {
            output[i] = all / nums[i];
        }

        return output;
    }
}
