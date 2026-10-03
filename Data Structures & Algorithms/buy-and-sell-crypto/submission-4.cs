public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int bp = prices[0];
        int sp;
        int maxProfit = 0;

        // for (int i=0; i<prices.Length; i++)
        // {
        //     bp = prices[i];

        //     for (int j=i+1; j<prices.Length; j++)
        //     {
        //         sp = prices [j];
        //         int profit = sp - bp;

        //         if (profit > maxProfit)
        //             maxProfit = profit;
        //     }
        // }

        for (int i=1; i<prices.Length; i++)
        {
            if (bp > prices[i])
                bp = prices[i];

            else
            {
                int profit = prices[i] - bp;
                Console.WriteLine(profit);

                if (profit > maxProfit)
                    maxProfit = profit;
            }
        }

        // if (maxProfit < 0)
        //     return 0;
        // else
            return maxProfit;   
    }
}
