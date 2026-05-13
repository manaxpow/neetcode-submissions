public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        var dict = new Dictionary<int,int>();
        for(int i=0; i< numbers.Length; i++)
        {
            if(dict.TryGetValue(numbers[i],out int index))
            {
                return [index+1,i+1];
            }
            else
            {
                dict[target-numbers[i]] = i;
            }
        }
        return [0,0];
    }
}
