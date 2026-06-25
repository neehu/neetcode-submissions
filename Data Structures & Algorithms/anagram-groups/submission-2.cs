public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();
        var hash = new Dictionary<string,int>();

        int n = strs.Length;


        if(strs.Length == 1) {
            
            result.Add(new List<string>(){strs[0]});
            return result;
        }

      for(int i = 0; i < strs.Length ; i++){
        var copyChars = strs[i].ToCharArray();
        Array.Sort(copyChars);
        var copy = new string(copyChars);
        if(hash.ContainsKey(copy)){
            continue;
        }

        result.Add(new List<string>(){strs[i]});

        for(int j = i+1; j < n; j++)
        {
           var destChars = strs[j].ToCharArray();
        Array.Sort(destChars);
        var destCopy = new string(destChars);

            if ( copy == destCopy){
                result.Last().Add(strs[j]);
                
                if(!hash.ContainsKey(destCopy)){
                hash.Add(destCopy,j);
                }
            }
        }
    }
       return result;
}
}
