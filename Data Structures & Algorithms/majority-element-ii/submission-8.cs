public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int ele = 0; int count = 0;
        int ele2 = 0; int count1 = 0;
        var result = new List<int>();

        foreach (var num in nums){


            if( count == 0){
                ele = num;
                count = 1;
            }
            else if ( num == ele){
                count++;
            }
            else if( count1 == 0){
                ele2 = num;
                count1 = 1;
            }
            else if ( num == ele2){
                count1++;
            }
            else {
                count--;
                count1--;
            }

        }

        count = 0;
        count1 = 0;

        foreach(var nu in nums ){
            if( nu == ele) count++;
             if ( nu == ele2) count1++;
        }


        if( count > n/3) result.Add(ele);
        if( count1 > n/3 && ele != ele2) result.Add(ele2);

        return result;
    }
}