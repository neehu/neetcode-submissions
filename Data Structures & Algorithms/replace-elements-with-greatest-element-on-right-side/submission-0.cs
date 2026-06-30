public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;

        int k = 0;
        int j = 1;

        for(int i = 0; i <= n - 2; i++){

            int max = arr[i+1];
            j = i + 2;
            while(j < n){
                max = Math.Max(arr[j],max);
                j++;
            }
                arr[i] = max;
            }
        arr[n-1] = -1;
        return arr;
        }

    }