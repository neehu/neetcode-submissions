public class Solution {

    public string Encode(IList<string> strs) {
        System.Text.StringBuilder encodedString = new System.Text.StringBuilder();

        foreach(var str in strs){
            encodedString.Append(str.Length.ToString());
            encodedString.Append(',');
            encodedString.Append(str);

        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {

        int n = s.Length;
        List<string> decodedStrings = new List<string>();
        for(int i = 0; i < n;){

            System.Text.StringBuilder len = new System.Text.StringBuilder();

            while( i < n && s[i] != ',' ){
                len.Append(s[i]);
                i++;
            }
            int length = Int32.Parse(len.ToString());
            i += 1;
            System.Text.StringBuilder decodedString = new System.Text.StringBuilder();
            int lastIndex = i+length;

            while(i < lastIndex){
                decodedString.Append(s[i]);
                i++;
            }
            decodedStrings.Add(decodedString.ToString());
        }

        return decodedStrings;
   }
}
