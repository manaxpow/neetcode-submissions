public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0, l = 0, r = 1;
        while(r<prices.Length)
        {
            if(prices[r] >prices[l])
            {
                profit = Math.Max(profit, prices[r] - prices[l]);
            }
            else
                l=r;
            r++;
        }
        return profit;
    }
}
