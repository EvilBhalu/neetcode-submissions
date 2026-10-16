public class Solution {
    public int MaxProfit(int[] prices) 
    {
        // int bp = prices[0];
        // int sp;
        // int maxProfit = 0;

        // // for (int i=0; i<prices.Length; i++)
        // // {
        // //     bp = prices[i];

        // //     for (int j=i+1; j<prices.Length; j++)
        // //     {
        // //         sp = prices [j];
        // //         int profit = sp - bp;

        // //         if (profit > maxProfit)
        // //             maxProfit = profit;
        // //     }
        // // }

        // for (int i=1; i<prices.Length; i++)
        // {
        //     if (bp > prices[i])
        //         bp = prices[i];

        //     else
        //     {
        //         int profit = prices[i] - bp;
        //         Console.WriteLine(profit);

        //         if (profit > maxProfit)
        //             maxProfit = profit;
        //     }
        // }

        // if (maxProfit < 0)
        //     return 0;
        // else
        //     return maxProfit;

        int l = 0, best = 0;

        for (int r=0; r<prices.Length; r++)
        {
            // Add r
            // this step is empty in stock question

            // validity check
            while (prices[l] > prices[r])
            {
                l++;
            }

            // update best
            best = Math.Max(best, prices[r] - prices[l]);
        }

        return best;   
    }
}
