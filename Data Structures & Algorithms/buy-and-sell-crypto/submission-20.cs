public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <2) return 0;

        int profit = 0;
        int l = 0;
        int r = 1;
        while(r<prices.Length)
        {
            if(prices[r] - prices[l] > profit) profit = prices[r] - prices[l];

            if(prices[r] <prices[l])
            {
                l=r;
            }
            r++;
        }


        return profit;
    }
}
