public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;

        foreach(var passenger in details){

            int n = passenger.Length - 1;
            char digit = passenger[n-3];
            char digit2 = passenger[n-2];

            int age = int.Parse( $"{digit}{digit2}");

            if(age > 60){
                count++;
            }
        }

        return count;
    }
}