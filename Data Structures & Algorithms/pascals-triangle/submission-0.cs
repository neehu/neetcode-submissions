public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> result = new List<List<int>>();

        for(int i = 0; i < numRows; i++){
            var row = new List<int>();
            int sum = 1;
            for(int j = 0; j <= i; j++){
                if( j == 0 || j == i){
                    row.Add(1);
                }
                else {
                    sum = result[i-1][j-1]+ result[i-1][j];
                    row.Add(sum);
                }
            }
            result.Add(row);
        }

        return result;
    }
}