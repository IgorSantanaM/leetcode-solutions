public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Fix #2: Skip the same element to avoid duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;

            int a = nums[i];
            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int threeSum = a + nums[l] + nums[r];

                if (threeSum > 0)
                {
                    r--;
                }
                else if (threeSum < 0)
                {
                    l++;
                }
                else
                {
                    // Fix #1: Add the actual values, not the indices l and r
                    result.Add(new List<int> { a, nums[l], nums[r] });
                    
                    // Fix #3: Wrapped the pointer updates inside explicit braces
                    l++;
                    
                    // Skip duplicates for the left pointer
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
            }
        }

        return result;
    }
}