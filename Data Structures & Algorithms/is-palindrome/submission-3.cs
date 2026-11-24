public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length;
        int left = 0;
        int right = n - 1;

        string newString = s.ToLower();

        while(right > left) {
            if(!char.IsLetterOrDigit(newString[left])) {
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(newString[right])) {
                right--;
                continue;
            }

            if(newString[left] != newString[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}