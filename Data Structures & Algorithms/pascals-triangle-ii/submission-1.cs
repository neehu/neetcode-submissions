public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> row = new List<int>();
        row.Add(1);
        long val = 1;
        for(int i = 1 ; i <= rowIndex; i++){
           val = val * (rowIndex-i+1)/i;
           row.Add((int)val);
        }

        return row;
    }
}
