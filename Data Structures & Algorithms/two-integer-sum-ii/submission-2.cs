public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int l = 0;
        int r = n - 1;
        while( l < r)
        {
            int currentSum = numbers[l] + numbers[r];

            if(currentSum > target)
                r--;
            else if(currentSum < target)
                l++;
            else
                return [l + 1, r + 1];
        }

        return [];

    }
}
