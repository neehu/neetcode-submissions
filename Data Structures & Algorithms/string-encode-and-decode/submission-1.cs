

public class Solution {
    public string Encode(IList<string> strs) {
        string encodedString = "";

        foreach (var str in strs) {
            string len = str.Length.ToString();
            encodedString += len;
            encodedString += ',';
            encodedString += str;
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        int n = s.Length;
        List<string> decodedStrings = new List<string>();
        for (int i = 0; i < n;) {
            string len = "";
            while (i < n && s[i] != ',') {
                len += s[i];
                i++;
            }
            i = i + 1;
            int length =  Int32.Parse(len);
            string decodedString = "";
            int lastIndex = length + i;

            while (i < lastIndex) {
                decodedString += s[i];
                i++;
            }
            decodedStrings.Add(decodedString.ToString());


        }

        return decodedStrings;
    }
}
