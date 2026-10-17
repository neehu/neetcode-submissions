public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int ele1 = 0 ; int count1 = 0;
        int ele2 = 0; int count2 = 0;
        List<int> result = new List<int>();

        foreach(int num in nums){
            if ( count1 == 0){
                ele1 = num;
                count1 = 1;
            }
            else if( ele1 == num){
                count1++;
            }
            else if ( count2 == 0) {
                ele2 = num;
                count2 = 1;
            }
            else if ( ele2 == num){
                count2++;
            }
            else {
                count1--;
                count2--;
            }

        }

        count1 = 0; count2 = 0;

        foreach(int nu in nums){
            if(ele1 == nu) count1++;
            else if ( ele2 == nu) {
                count2++;
            }
        }

        if(count1 > (n/3)){
            result.Add(ele1);
        }
         if ( ele1 != ele2 && count2 > (n/3)){
            result.Add(ele2);
        }

        return result;
    }
}