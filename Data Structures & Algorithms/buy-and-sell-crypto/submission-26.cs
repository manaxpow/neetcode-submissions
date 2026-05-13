public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <2) return 0;

        int profit = 0;
        int l = 0;
        int r = 1;
        while(r<prices.Length)
        {
            if(prices[r] >prices[l])
            {
                profit = Math.Max(profit, prices[r] - prices[l]);
            }
            else
            {
                l=r;
            }
            r++;
        }
        return profit;
    }
}
