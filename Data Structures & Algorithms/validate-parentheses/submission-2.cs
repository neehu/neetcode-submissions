public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> closeToOpen = new Dictionary<char,char>() 
        {
            {')','('},
            {'}','{'},
            {']','['}
        };

        int n = s.Length;
        Stack<char> list = new Stack<char>();

        for(int i = 0; i < n; i++){

            if(closeToOpen.ContainsKey(s[i])){
                if( list.Count > 0 && list.Peek() == closeToOpen[s[i]] ){
                    list.Pop();
                }
                else {
                    return false;
                }
            }
            else {
                list.Push(s[i]);
            }
        }

        if(list.Count == 0) return true;

        return false;
    }
}
