public class MinStack {
    
    List<int> stack;

    public MinStack() {
        stack = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
    }
    
    public void Pop() {
        int n = stack.Count - 1;
        stack.RemoveAt(n);
    }
    
    public int Top() {
        int n = stack.Count - 1;
        int target = stack[n];
        return target;
    }
    
    public int GetMin() {
        int min = int.MaxValue;

        foreach(int num in stack) if(num < min) min = num;
        return min;
    }
}
