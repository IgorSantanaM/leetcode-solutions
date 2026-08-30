public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        Backtrack(nums, 0, new List<int>(), result);
        return result;
    }

    public void Backtrack(int[] nums, int index, IList<int> currentSubset, IList<List<int>> result)
    {
        if(index >= nums.Length)
        {
            result.Add(new List<int>(currentSubset));
            return;
        }
        currentSubset.Add(nums[index]);
        Backtrack(nums, index + 1, currentSubset, result);
        currentSubset.RemoveAt(currentSubset.Count - 1);
        Backtrack(nums, index + 1, currentSubset, result);
    }
}
