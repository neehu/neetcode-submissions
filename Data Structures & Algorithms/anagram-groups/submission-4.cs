public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var hash = new Dictionary<string,List<string>>();

        int n = strs.Length;


      for(int i = 0; i < strs.Length ; i++){

        var copyChars = strs[i].ToCharArray();
        Array.Sort(copyChars);
        var key = new string(copyChars);

        if(!hash.ContainsKey(key)){
            hash.Add(key,new List<string>());
        }

        hash[key].Add(strs[i]);

       
    }
       return hash.Values.ToList();
}
}
