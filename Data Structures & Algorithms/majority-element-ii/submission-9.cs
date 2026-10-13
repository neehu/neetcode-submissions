public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        List<int> result = new List<int>();

        if (n == 0 ) return result;

        int ele1 = 0; int count1 = 0;
        int ele2 = 0; int count2 = 0;
        
        foreach(int num in nums){
            if( num == ele1){
                count1++;
            }
            else if (num == ele2){
                count2++;
            }
            else if (count1 == 0){
                ele1 = num;
                count1 = 1;
            }
            else if ( count2 == 0){
                ele2 = num;
                count2 = 1;
            }
            else {
                count1--;
                count2--;
            }
        }

        count1 = 0;
        count2 = 0;
        foreach(int number in nums){
            if(number == ele1) count1++;
            else if( number == ele2) count2++;
        }

        if(count1 > n/3) result.Add(ele1);
        if( ele1 != ele2 && count2 > n/3 ) result.Add(ele2);

        return result;
    }
}