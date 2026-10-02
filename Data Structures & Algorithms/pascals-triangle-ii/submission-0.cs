public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<List<int>> result = new List<List<int>>();

        for(int i = 0 ; i <= rowIndex; i++){
            var row = new List<int>();
            row.Add(1);
            
            for(int j = 1; j < i ; j++){
                var num = result[i - 1][j - 1] + result[i - 1][j];
                row.Add(num);
            }

            if( i > 0) row.Add(1);
            result.Add(row);
        }

        return result[rowIndex];
    }
}
