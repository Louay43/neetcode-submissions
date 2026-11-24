public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int n = numbers.Length;
        int left = 0;
        int right = n - 1;

        while(left < right) {
            int farRight = numbers[right];
            int farLeft = numbers[left];

            int sum = farLeft + farRight;

            if(sum == target) {
                return new int[] { left + 1, right + 1 };
            }
            else if(sum > target) {
                right--;
            }
            else {
                left++;
            }
        }

        return new int[0];
    }
}