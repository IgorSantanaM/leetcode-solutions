public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int result = int.MinValue;

        foreach(var num in set)
        {
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
