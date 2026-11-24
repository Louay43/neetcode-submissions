public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;

        (int position, double time)[] cars = new (int, double)[n];

        Stack<(int position, double time)> stack = new();

        for(int i = 0; i < n; i++) {
            cars[i] = (
                position[i],
                (double)(target - position[i]) / speed[i]
            );
        }

        Array.Sort(cars, (a, b) => b.position.CompareTo(a.position));

        foreach(var car in cars) {
            if(stack.Count == 0 || car.time > stack.Peek().time) {
                stack.Push(car);
            }
        }

        return stack.Count;
    }
}