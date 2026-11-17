public class Solution {

    public string Encode(IList<string> strs) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        foreach(var str in strs){
            int n = str.Length;
            sb.Append(n.ToString());
            sb.Append(',');
            sb.Append(str);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int n = s.Length;
        List<string> decoded = new List<string>();

        for(int i = 0; i < n;){
            int startindex = i;
            System.Text.StringBuilder len = new System.Text.StringBuilder();

            while (s[i] != ','){
                len.Append(s[i]);
                i++;
            }
           int length = Int32.Parse(len.ToString());

            i = i + 1;
            int finalLength = i + length;

            System.Text.StringBuilder str = new System.Text.StringBuilder();

            while( i < finalLength){
                str.Append(s[i]);
                i++;
            }
            decoded.Add(str.ToString());


        }

        return decoded;
   }
}
