public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        Backtrack(nums, new List<int>(), result);
        return result;
    }

    public void Backtrack(int[] nums, IList<int> currentPermutation, IList<List<int>> result)
    {
        if(currentPermutation.Count >= nums.Length)
        {
            result.Add(new List<int>(currentPermutation));
            return;
        }

        foreach(int num in nums)
        {
            if(currentPermutation.Contains(num))
                continue;
            
            currentPermutation.Add(num);

            Backtrack(nums, currentPermutation, result);

            currentPermutation.RemoveAt(currentPermutation.Count -1);
        }
    }
}
