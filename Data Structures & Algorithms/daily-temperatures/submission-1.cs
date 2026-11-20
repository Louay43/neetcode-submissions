
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
            int n = temperatures.Length;
                    int[] res = new int[n];
                            Stack<int> stack = new Stack<int>();

                                    for (int i = n - 1; i >= 0; i--) {

                                                while (stack.Count > 0 &&
                                                                   temperatures[i] >= temperatures[stack.Peek()]) {
                                                                                   stack.Pop();
                                                                                               }

                                                                                                           if (stack.Count == 0) {
                                                                                                                           res[i] = 0;
                                                                                                                                       }
                                                                                                                                                   else {
                                                                                                                                                                   res[i] = stack.Peek() - i;
                                                                                                                                                                               }

                                                                                                                                                                                           stack.Push(i);
                                                                                                                                                                                                   }

                                                                                                                                                                                                           return res;
                                                                                                                                                                                                               }
                                                                                                                                                                                                               }
                                                                                                                                                                                                               
