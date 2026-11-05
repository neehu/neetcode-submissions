

public class Solution {
    public string Encode(IList<string> strs) {
        System.Text.StringBuilder encodedString = new System.Text.StringBuilder();
        foreach (var str in strs) {
            string len = str.Length.ToString();
            encodedString.Append(len);
            encodedString.Append(',');
            encodedString.Append(str);
        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {
        int n = s.Length;
        List<string> decodedStrings = new List<string>();
        for (int i = 0; i < n;) {
            System.Text.StringBuilder len = new System.Text.StringBuilder();
            while (i < n && s[i] != ',') {
                len.Append(s[i]);
                i++;
            }
            i = i + 1;
            int length =  Int32.Parse(len.ToString());
             System.Text.StringBuilder decodedString = new  System.Text.StringBuilder();
            int lastIndex = length + i;

            while (i < lastIndex) {
                decodedString.Append(s[i]);
                i++;
            }
            decodedStrings.Add(decodedString.ToString());

        }

        return decodedStrings;
    }
}
