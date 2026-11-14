public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(var token in tokens){
            switch(token){
                case "+":
                case "-":
                case "*":
                case "/":

                int right = stack.Pop();
                int left = stack.Pop();

                if(token == "+"){
                    stack.Push( left + right );
                }
                else if (token == "-"){
                    stack.Push(left - right );
                }
                else if (token == "*"){
                    stack.Push(left * right);
                }
                else if (token == "/"){
                    stack.Push(left/right);
                }
                break;
            default:
                stack.Push( Int32.Parse(token));
                break;
            }
        }

        return stack.Pop();
    }
}
