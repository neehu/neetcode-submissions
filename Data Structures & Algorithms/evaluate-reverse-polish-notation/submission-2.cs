public class Solution {
    public int EvalRPN(string[] s) {
        Dictionary<string,int> hash = new Dictionary<string,int> {
           { "+",1},
            {"-",2},
            {"*",3},
            {"/",4}
        };

        Stack<int> stack = new Stack<int>();

        foreach( string token in s ){
            switch(token){
                case "+":
                case "-":
                case "*":
                case "/":
                int right = stack.Pop();
                int left = stack.Pop();
                int result;
                if(token == "+"){
                result = left + right;
                }
                else if ( token == "-"){
                    result = left - right;
                }
                else if (token == "*" ){
                    result = left * right;
                }
                else {
                    result = left / right;
                }

                stack.Push(result);
                break;
                default:
                stack.Push(int.Parse(token));
                break;
            }
        }

        return stack.Pop();
    }
}
