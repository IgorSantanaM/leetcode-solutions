public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length <= 1)
            return nums.Length;

        HashSet<int> set = new(nums);
        int result = int.MinValue;

        foreach(var num in set)
        {
            if(set.Contains(num-1)) continue;
            int currentCount = 0;
            int i = num;
            
            while(set.Contains(i))
            {
                currentCount++;
                i++;
            }

            result = Math.Max(result, currentCount);
        }

        return result == int.MinValue ? 0 : result;
    }
}
