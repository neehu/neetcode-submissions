public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        Stack<int> stack = new Stack<int>();
        int[] result = new int[n];
        for(int i = 0; i < n; i++){
            
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()] ){
                result[stack.Peek()] = i - stack.Peek();
                stack.Pop();
            }
            stack.Push(i);
        }

        return result;
    }
}
