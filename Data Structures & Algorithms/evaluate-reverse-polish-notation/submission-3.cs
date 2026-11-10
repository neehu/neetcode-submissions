public class Solution {
    public int EvalRPN(string[] tokens) {
        int n = tokens.Length;
        Stack<int> stack = new Stack<int>();

        foreach(var token in tokens){
            switch(token){
                case "+":
                case "-":
                case "*":
                case "/":
                int right = stack.Pop();
                int left = stack.Pop();
                int result = 0;
                if( token == "+"){
                    result = left + right;
                }
                else if ( token == "-"){
                    result = left - right;
                }
                else if (token == "*"){
                    result = left * right;
                }
                else {
                    result = left/right;
                }
                Console.WriteLine(result);
                stack.Push(result);
                break;
                default:
                stack.Push(Int32.Parse(token));
                break;
            }
        }

        return stack.Pop();
    }
}
