public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int e1= 0 ; int c1 = 0;
        int e2 = 0; int c2 = 0;
        List<int> result = new List<int>();

        foreach( int x in nums){
            if( c1 > 0 && e1 == x) c1++;
            else if ( c2 > 0 && e2 == x) c2++;
            else if ( c1 == 0){ e1 = x; c1 = 1;}
            else if ( c2 == 0 ) { e2 = x; c2 = 1;}
            else { c1--; c2--;}
        }

        c1 = 0;
        c2 = 0;

        foreach (int y in nums){
            if( y == e1) c1++;
            if( y == e2 ) c2++;
        }

        if( c1 > (n/3) ) result.Add(e1);
        if( c2 > (n/3) ) result.Add(e2);

        return result;
    }
}