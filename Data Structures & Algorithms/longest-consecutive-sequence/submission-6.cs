public class Solution {
    public int LongestConsecutive(int[] nums) {
       if(nums.Length <= 1)
        return nums.Length;

        int result = 0;

        HashSet<int> set = new(nums);

        foreach(var num in nums)
        {
            if(set.Contains(num - 1)) continue;
            int currentCount = 0;
            int i = num;

            while(set.Contains(i))
            {
                currentCount++;
                i++;
            }

            result = Math.Max(result, currentCount);
        }

        return result;
    }
}
