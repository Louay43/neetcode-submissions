public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach (string str in tokens) {
            switch (str) {
                case "+": {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a + b);
                    break;
                }
                case "-": {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                    break;
                }
                case "*": {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a * b);
                    break;
                }
                case "/": {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b / a);
                    break;
                }
                default:
                    stack.Push(int.Parse(str));
                    break;
            }
        }

        return stack.Pop();
    }
}