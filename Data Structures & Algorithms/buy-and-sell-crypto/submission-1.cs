public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int l = 0, r = 1;
        int maxDiff = 0;

        while(r < n)
        {
            if(prices[l] < prices[r])
            {
                int currentDiff = prices[r] - prices[l]; 
                maxDiff = Math.Max(currentDiff, maxDiff);
            }
            else
                l = r;
            r++;
        }
        return maxDiff;
    }
}
