public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int count1 = 0; int ele1 = 0;
        int count2 = 0; int ele2 = 0;
        List<int> result = new List<int>();

        foreach(int ele in nums ){
            if( count1 == 0 ){
                ele1 = ele;
                count1 = 1;
            }
            else if ( ele1 == ele ){
                count1++;
            }
            else if ( count2 == 0 ){
                ele2 = ele;
                count2 = 1;
            }
            else if ( ele2 == ele ){
                count2++;
            }
            else {
                count1--;
                count2--;
            }
        }

        count1 = 0; count2 = 0;


        foreach(var e in nums){
            if( e == ele1){
                count1++;
            }
            else if ( e == ele2) {
                count2++;
            }
        }

        if (count1 > n/3) result.Add(ele1);
        if (ele1 != ele2 && count2 > n/3) result.Add(ele2);

        return result;
    }
}