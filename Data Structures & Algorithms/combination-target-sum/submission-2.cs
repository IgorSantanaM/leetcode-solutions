public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        Backtrack(nums, 0, new List<int>(), target, result);
        return result;
    }

    public void Backtrack(int[] nums, int start, List<int> currentSum, int target, IList<List<int>> result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(currentSum));
            return;
        }

        for(int i = start; i < nums.Length; i++)
        {
            start = i;
            if(nums[i] > target)
                continue;
            currentSum.Add(nums[i]);
            Backtrack(nums, start, currentSum, target - nums[i], result);
            currentSum.RemoveAt(currentSum.Count - 1);
        }
    }
}
