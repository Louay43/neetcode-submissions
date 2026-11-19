
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> list = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {

            // Remove elements outside the window
            while (deque.Count > 0 && deque.First.Value < left) {
                deque.RemoveFirst();
            }

            // Remove smaller elements from the back
            while (deque.Count > 0 &&
                   nums[deque.Last.Value] <= nums[right]) {
                deque.RemoveLast();
            }

            // Add current index
            deque.AddLast(right);

            // Window has reached size k
            if (right >= k - 1) {
                list.Add(nums[deque.First.Value]);
                left++;
            }
        }

        return list.ToArray();
    }
}
