public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new();
        int result = int.MinValue;
        foreach(var num in nums)
        {
            set.Add(num);
        }

        foreach(var num in set)
        {
            int currentCount = 0;
            if(!set.Contains(num - 1))
            {
                currentCount++;
                int i = num;
                while(set.Contains(++i))
                {
                    currentCount++;
                }
            }

            result = Math.Max(result, currentCount);
        }

        return result == int.MinValue ? 0 : result;
    }
}
